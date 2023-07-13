namespace WinFormsAppRSP
{
    partial class FrmAlumno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNota = new TextBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDNI = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnCancelar = new Button();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // txtNota
            // 
            txtNota.Location = new Point(16, 163);
            txtNota.Name = "txtNota";
            txtNota.Size = new Size(266, 23);
            txtNota.TabIndex = 19;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(16, 119);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(266, 23);
            txtNombre.TabIndex = 18;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(16, 75);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(266, 23);
            txtApellido.TabIndex = 17;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(16, 31);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(266, 23);
            txtDNI.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 145);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 15;
            label4.Text = "Nota:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 101);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 14;
            label3.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 57);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 13;
            label2.Text = "Apellido:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 13);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 12;
            label1.Text = "DNI:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(207, 220);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(16, 220);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 10;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // FrmAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(298, 257);
            Controls.Add(txtNota);
            Controls.Add(txtNombre);
            Controls.Add(txtApellido);
            Controls.Add(txtDNI);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Name = "FrmAlumno";
            Text = "FrmAlumno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNota;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDNI;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnCancelar;
        private Button btnAceptar;
    }
}