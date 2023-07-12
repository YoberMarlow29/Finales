namespace FORMULARIOS
{
    partial class FrmModificarCliente
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
            btnCancelar = new Button();
            btnAceptar = new Button();
            cboNacionalidad = new ComboBox();
            txtDni = new TextBox();
            txtEdad = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(136, 238);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 24;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(29, 238);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 23;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // cboNacionalidad
            // 
            cboNacionalidad.FormattingEnabled = true;
            cboNacionalidad.Location = new Point(122, 190);
            cboNacionalidad.Name = "cboNacionalidad";
            cboNacionalidad.Size = new Size(241, 23);
            cboNacionalidad.TabIndex = 22;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(122, 146);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(241, 23);
            txtDni.TabIndex = 21;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(122, 107);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(241, 23);
            txtEdad.TabIndex = 20;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(122, 69);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(241, 23);
            txtApellido.TabIndex = 19;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(122, 30);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(241, 23);
            txtNombre.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 193);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 17;
            label5.Text = "Nacionalidad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 154);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 16;
            label4.Text = "DNI:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 115);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 15;
            label3.Text = "Edad: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 77);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 14;
            label2.Text = "Apellido:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 33);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 13;
            label1.Text = "Nombre:";
            // 
            // FrmModificarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 295);
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
            Name = "FrmModificarCliente";
            Text = "FrmModificarCliente";
            Load += FrmModificarCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnAceptar;
        private ComboBox cboNacionalidad;
        private TextBox txtDni;
        private TextBox txtEdad;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}