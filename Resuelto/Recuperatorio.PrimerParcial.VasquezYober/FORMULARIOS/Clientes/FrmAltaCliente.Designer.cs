namespace FORMULARIOS
{
    partial class FrmAltaCliente
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtEdad = new TextBox();
            txtDni = new TextBox();
            cboNacionalidad = new ComboBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 35);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 79);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 117);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Edad: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 156);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 3;
            label4.Text = "DNI:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 195);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 4;
            label5.Text = "Nacionalidad:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(105, 32);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(241, 23);
            txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(105, 71);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(241, 23);
            txtApellido.TabIndex = 6;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(105, 109);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(241, 23);
            txtEdad.TabIndex = 7;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(105, 148);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(241, 23);
            txtDni.TabIndex = 9;
            // 
            // cboNacionalidad
            // 
            cboNacionalidad.FormattingEnabled = true;
            cboNacionalidad.Location = new Point(105, 192);
            cboNacionalidad.Name = "cboNacionalidad";
            cboNacionalidad.Size = new Size(241, 23);
            cboNacionalidad.TabIndex = 10;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(12, 240);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 11;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(119, 240);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmAltaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 288);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(cboNacionalidad);
            Controls.Add(txtDni);
            Controls.Add(txtEdad);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmAltaCliente";
            Text = "FrmAltaCliente";
            Load += FrmAltaCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtEdad;
        private TextBox txtDni;
        private ComboBox cboNacionalidad;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}