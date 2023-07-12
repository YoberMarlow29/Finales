namespace FinalLaboratorio2023
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnObtenerPlanetas = new Button();
            btnMostrarEnHilos = new Button();
            btnSerializar = new Button();
            btnDeserializar = new Button();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Green;
            btnAgregar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.Location = new Point(91, 357);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(111, 58);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(192, 192, 0);
            btnModificar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.Location = new Point(331, 357);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(111, 58);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Maroon;
            btnEliminar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.Location = new Point(571, 357);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(111, 58);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnObtenerPlanetas
            // 
            btnObtenerPlanetas.BackColor = SystemColors.ActiveCaption;
            btnObtenerPlanetas.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnObtenerPlanetas.Location = new Point(26, 39);
            btnObtenerPlanetas.Name = "btnObtenerPlanetas";
            btnObtenerPlanetas.Size = new Size(86, 90);
            btnObtenerPlanetas.TabIndex = 4;
            btnObtenerPlanetas.Text = "Obtener Planetas";
            btnObtenerPlanetas.UseVisualStyleBackColor = false;
            // 
            // btnMostrarEnHilos
            // 
            btnMostrarEnHilos.BackColor = Color.FromArgb(0, 192, 192);
            btnMostrarEnHilos.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMostrarEnHilos.Location = new Point(630, 39);
            btnMostrarEnHilos.Name = "btnMostrarEnHilos";
            btnMostrarEnHilos.Size = new Size(86, 90);
            btnMostrarEnHilos.TabIndex = 5;
            btnMostrarEnHilos.Text = "Ver en hilos";
            btnMostrarEnHilos.UseVisualStyleBackColor = false;
            // 
            // btnSerializar
            // 
            btnSerializar.BackColor = Color.Silver;
            btnSerializar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSerializar.Location = new Point(26, 186);
            btnSerializar.Name = "btnSerializar";
            btnSerializar.Size = new Size(86, 90);
            btnSerializar.TabIndex = 6;
            btnSerializar.Text = "Serializar";
            btnSerializar.UseVisualStyleBackColor = false;
            // 
            // btnDeserializar
            // 
            btnDeserializar.BackColor = Color.FromArgb(255, 192, 255);
            btnDeserializar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeserializar.Location = new Point(630, 186);
            btnDeserializar.Name = "btnDeserializar";
            btnDeserializar.Size = new Size(102, 100);
            btnDeserializar.TabIndex = 7;
            btnDeserializar.Text = "Deserializar";
            btnDeserializar.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDeserializar);
            Controls.Add(btnSerializar);
            Controls.Add(btnMostrarEnHilos);
            Controls.Add(btnObtenerPlanetas);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Name = "Form1";
            Text = "Final Laboratorio";
            ResumeLayout(false);
        }

        #endregion
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnObtenerPlanetas;
        private Button btnMostrarEnHilos;
        private Button btnSerializar;
        private Button btnDeserializar;
    }
}