namespace Tareas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lstTareasCompletadas = new System.Windows.Forms.ListBox();
            this.lstTareasPendientes = new System.Windows.Forms.ListBox();
            this.txtNombreTarea = new System.Windows.Forms.TextBox();
            this.txtIdEliminar = new System.Windows.Forms.TextBox();
            this.btnMarcarCompletada = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Location = new System.Drawing.Point(12, 325);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(160, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Location = new System.Drawing.Point(515, 323);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(154, 23);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Location = new System.Drawing.Point(12, 382);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(160, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lstTareasCompletadas
            // 
            this.lstTareasCompletadas.FormattingEnabled = true;
            this.lstTareasCompletadas.Location = new System.Drawing.Point(515, 80);
            this.lstTareasCompletadas.Name = "lstTareasCompletadas";
            this.lstTareasCompletadas.Size = new System.Drawing.Size(273, 225);
            this.lstTareasCompletadas.TabIndex = 4;
            // 
            // lstTareasPendientes
            // 
            this.lstTareasPendientes.FormattingEnabled = true;
            this.lstTareasPendientes.Location = new System.Drawing.Point(12, 80);
            this.lstTareasPendientes.Name = "lstTareasPendientes";
            this.lstTareasPendientes.Size = new System.Drawing.Size(273, 225);
            this.lstTareasPendientes.TabIndex = 6;
            // 
            // txtNombreTarea
            // 
            this.txtNombreTarea.Location = new System.Drawing.Point(190, 328);
            this.txtNombreTarea.Name = "txtNombreTarea";
            this.txtNombreTarea.Size = new System.Drawing.Size(204, 20);
            this.txtNombreTarea.TabIndex = 7;
            // 
            // txtIdEliminar
            // 
            this.txtIdEliminar.Location = new System.Drawing.Point(190, 385);
            this.txtIdEliminar.Name = "txtIdEliminar";
            this.txtIdEliminar.Size = new System.Drawing.Size(204, 20);
            this.txtIdEliminar.TabIndex = 8;
            // 
            // btnMarcarCompletada
            // 
            this.btnMarcarCompletada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarcarCompletada.Location = new System.Drawing.Point(515, 385);
            this.btnMarcarCompletada.Name = "btnMarcarCompletada";
            this.btnMarcarCompletada.Size = new System.Drawing.Size(154, 23);
            this.btnMarcarCompletada.TabIndex = 9;
            this.btnMarcarCompletada.Text = "Tarea Completada";
            this.btnMarcarCompletada.UseVisualStyleBackColor = true;
            this.btnMarcarCompletada.Click += new System.EventHandler(this.btnMarcarCompletada_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "TAreas pendientes ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(510, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tareas completadas ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMarcarCompletada);
            this.Controls.Add(this.txtIdEliminar);
            this.Controls.Add(this.txtNombreTarea);
            this.Controls.Add(this.lstTareasPendientes);
            this.Controls.Add(this.lstTareasCompletadas);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "WR";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ListBox lstTareasCompletadas;
        private System.Windows.Forms.ListBox lstTareasPendientes;
        private System.Windows.Forms.TextBox txtNombreTarea;
        private System.Windows.Forms.TextBox txtIdEliminar;
        private System.Windows.Forms.Button btnMarcarCompletada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

