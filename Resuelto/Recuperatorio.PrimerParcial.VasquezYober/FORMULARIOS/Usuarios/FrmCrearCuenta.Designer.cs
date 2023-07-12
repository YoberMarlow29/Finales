namespace FORMULARIOS
{
    partial class FrmCrearCuenta
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
            txtClave = new TextBox();
            txtCorreo = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(156, 177);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 24;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(49, 177);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 23;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(94, 132);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(241, 23);
            txtClave.TabIndex = 21;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(94, 93);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(241, 23);
            txtCorreo.TabIndex = 20;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(94, 55);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(241, 23);
            txtApellido.TabIndex = 19;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(94, 16);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(241, 23);
            txtNombre.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 140);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 16;
            label4.Text = "Clave:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 101);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 15;
            label3.Text = "Correo: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 63);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 14;
            label2.Text = "Apellido:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 13;
            label1.Text = "Nombre:";
            // 
            // FrmCrearCuenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 235);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtClave);
            Controls.Add(txtCorreo);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmCrearCuenta";
            Text = "FrmCrearCuenta";
            Load += FrmCrearCuenta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnAceptar;
        private TextBox txtClave;
        private TextBox txtCorreo;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}