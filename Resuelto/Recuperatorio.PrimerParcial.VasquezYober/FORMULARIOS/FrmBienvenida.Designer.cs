namespace FORMULARIOS
{
    partial class FrmBienvenida
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
            btnLogin = new Button();
            btnCrearCuenta = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(40, 69);
            label1.Name = "label1";
            label1.Size = new Size(659, 37);
            label1.TabIndex = 0;
            label1.Text = "BIENVENIDOS AL SISTEMA DE REGISTRO DE CLIENTES\r\n";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(239, 136);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(223, 23);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "INGRESAR AL SISTEMA";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCrearCuenta
            // 
            btnCrearCuenta.Location = new Point(239, 180);
            btnCrearCuenta.Name = "btnCrearCuenta";
            btnCrearCuenta.Size = new Size(223, 23);
            btnCrearCuenta.TabIndex = 2;
            btnCrearCuenta.Text = "CREAR CUENTA";
            btnCrearCuenta.UseVisualStyleBackColor = true;
            btnCrearCuenta.Click += btnCrearCuenta_Click;
            // 
            // FrmBienvenida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 316);
            Controls.Add(btnCrearCuenta);
            Controls.Add(btnLogin);
            Controls.Add(label1);
            Name = "FrmBienvenida";
            Text = "FrmBienvenida";
            Load += FrmBienvenida_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnLogin;
        private Button btnCrearCuenta;
    }
}