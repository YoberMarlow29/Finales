namespace Formularios
{
    partial class FrmAuto
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
            txtPatente = new TextBox();
            txtColor = new TextBox();
            txtKms = new TextBox();
            txtModelo = new TextBox();
            txtMarca = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(195, 256);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 30);
            btnCancelar.TabIndex = 19;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(12, 256);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 30);
            btnAceptar.TabIndex = 18;
            btnAceptar.Text = "&Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtPatente
            // 
            txtPatente.Location = new Point(12, 216);
            txtPatente.Name = "txtPatente";
            txtPatente.Size = new Size(258, 23);
            txtPatente.TabIndex = 17;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(12, 169);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(258, 23);
            txtColor.TabIndex = 15;
            // 
            // txtKms
            // 
            txtKms.Location = new Point(12, 122);
            txtKms.Name = "txtKms";
            txtKms.Size = new Size(258, 23);
            txtKms.TabIndex = 13;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(12, 75);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(258, 23);
            txtModelo.TabIndex = 11;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(12, 28);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(258, 23);
            txtMarca.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 198);
            label5.Margin = new Padding(3, 3, 3, 0);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 16;
            label5.Text = "Patente:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 151);
            label4.Margin = new Padding(3, 3, 3, 0);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 14;
            label4.Text = "Color:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 104);
            label3.Margin = new Padding(3, 3, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 12;
            label3.Text = "Kms:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 57);
            label2.Margin = new Padding(3, 3, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 10;
            label2.Text = "Modelo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 8;
            label1.Text = "Marca:";
            // 
            // FrmAuto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 297);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtPatente);
            Controls.Add(txtColor);
            Controls.Add(txtKms);
            Controls.Add(txtModelo);
            Controls.Add(txtMarca);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmAuto";
            Text = "FrmAuto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnAceptar;
        private TextBox txtPatente;
        private TextBox txtColor;
        private TextBox txtKms;
        private TextBox txtModelo;
        private TextBox txtMarca;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}