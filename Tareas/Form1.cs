using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Dapper;
using Microsoft.VisualBasic;

namespace Tareas
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=DEX;Initial Catalog=TareaWR;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadPendingTasks();
            LoadCompletedTasks();
        }

        private void LoadPendingTasks()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM TareasWR WHERE Completada = 0";
                List<Tarea> tareas = connection.Query<Tarea>(query).ToList();

                lstTareasPendientes.Items.Clear();
                foreach (var tarea in tareas)
                {
                    lstTareasPendientes.Items.Add(tarea);
                }
            }
        }

        private void LoadCompletedTasks()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM TareasWR WHERE Completada = 1";
                List<Tarea> tareas = connection.Query<Tarea>(query).ToList();

                lstTareasCompletadas.Items.Clear();
                foreach (var tarea in tareas)
                {
                    lstTareasCompletadas.Items.Add(tarea);
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombreTarea = txtNombreTarea.Text;
            if (!string.IsNullOrWhiteSpace(nombreTarea))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO TareasWR (Nombre, Completada) VALUES (@Nombre, @Completada)";
                    var parameters = new { Nombre = nombreTarea, Completada = false };
                    connection.Execute(query, parameters);
                }

                LoadPendingTasks();
                txtNombreTarea.Text = string.Empty;
            }
        }


       

        public class Tarea
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public bool Completada { get; set; }
            public Color ColorLetra { get; internal set; }

            public override string ToString()
            {
                return $"{Id}: {Nombre} {(Completada ? "(Completada)" : "")}";
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtIdEliminar.Text))
            {
                int idEliminar;
                if (int.TryParse(txtIdEliminar.Text, out idEliminar))
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "DELETE FROM TareasWR WHERE Id = @Id";
                        var parameters = new { Id = idEliminar };
                        connection.Execute(query, parameters);
                    }

                    LoadPendingTasks();
                    LoadCompletedTasks();
                    txtIdEliminar.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un ID válido para eliminar la tarea.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID para eliminar la tarea.");
            }
        }

        private void btnMarcarCompletada_Click(object sender, EventArgs e)
        {
            if (lstTareasPendientes.SelectedIndex != -1)
            {
                Tarea tareaSeleccionada = (Tarea)lstTareasPendientes.SelectedItem;
                tareaSeleccionada.Completada = true;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE TareasWR SET Completada = @Completada WHERE Id = @Id";
                    var parameters = new { Completada = tareaSeleccionada.Completada, Id = tareaSeleccionada.Id };
                    connection.Execute(query, parameters);
                }

                LoadPendingTasks();
                LoadCompletedTasks();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lstTareasPendientes.SelectedIndex != -1)
            {
                Tarea tareaSeleccionada = (Tarea)lstTareasPendientes.SelectedItem;

                // Abre un cuadro de diálogo para editar el nombre de la tarea
                string nombreTareaEditada = Interaction.InputBox("Editar tarea", "Ingrese el nuevo nombre de la tarea", tareaSeleccionada.Nombre);

                if (!string.IsNullOrWhiteSpace(nombreTareaEditada))
                {
                    tareaSeleccionada.Nombre = nombreTareaEditada;

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "UPDATE TareasWR SET Nombre = @Nombre WHERE Id = @Id";
                        var parameters = new { Nombre = tareaSeleccionada.Nombre, Id = tareaSeleccionada.Id };
                        connection.Execute(query, parameters);
                    }

                    LoadPendingTasks();
                    LoadCompletedTasks();
                }
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}