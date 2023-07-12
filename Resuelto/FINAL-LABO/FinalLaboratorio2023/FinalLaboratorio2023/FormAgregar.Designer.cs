namespace FinalLaboratorio2023
{
    partial class FormAgregar
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
            btnAceptar = new Button();
            btnCancelar = new Button();
            txtId = new TextBox();
            lblId = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNombre = new TextBox();
            txtMasa = new TextBox();
            txtDiametro = new TextBox();
            txtSatelites = new TextBox();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAceptar.Location = new Point(70, 356);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(87, 41);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(267, 356);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(87, 41);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(141, 83);
            txtId.Name = "txtId";
            txtId.Size = new Size(213, 23);
            txtId.TabIndex = 2;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblId.Location = new Point(79, 81);
            lblId.Name = "lblId";
            lblId.Size = new Size(33, 21);
            lblId.TabIndex = 3;
            lblId.Text = "Id: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(37, 126);
            label1.Name = "label1";
            label1.Size = new Size(75, 21);
            label1.TabIndex = 4;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(60, 177);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 5;
            label2.Text = "Masa:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(30, 222);
            label3.Name = "label3";
            label3.Size = new Size(82, 21);
            label3.TabIndex = 6;
            label3.Text = "Diametro:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(30, 269);
            label4.Name = "label4";
            label4.Size = new Size(76, 21);
            label4.TabIndex = 7;
            label4.Text = "Satelites:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(141, 128);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(213, 23);
            txtNombre.TabIndex = 8;
            // 
            // txtMasa
            // 
            txtMasa.Location = new Point(141, 179);
            txtMasa.Name = "txtMasa";
            txtMasa.Size = new Size(213, 23);
            txtMasa.TabIndex = 9;
            // 
            // txtDiametro
            // 
            txtDiametro.Location = new Point(141, 224);
            txtDiametro.Name = "txtDiametro";
            txtDiametro.Size = new Size(213, 23);
            txtDiametro.TabIndex = 10;
            // 
            // txtSatelites
            // 
            txtSatelites.Location = new Point(141, 269);
            txtSatelites.Name = "txtSatelites";
            txtSatelites.Size = new Size(213, 23);
            txtSatelites.TabIndex = 11;
            // 
            // FormAgregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 450);
            Controls.Add(txtSatelites);
            Controls.Add(txtDiametro);
            Controls.Add(txtMasa);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblId);
            Controls.Add(txtId);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Name = "FormAgregar";
            Text = "FormAgregar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Button btnCancelar;
        private TextBox txtId;
        private Label lblId;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNombre;
        private TextBox txtMasa;
        private TextBox txtDiametro;
        private TextBox txtSatelites;
    }
}