namespace Formulario
{
    partial class Final
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
            btnPunto1 = new Button();
            btnPunto2 = new Button();
            btnPunto3 = new Button();
            btnPunto4 = new Button();
            btnPunto5 = new Button();
            btnPunto6 = new Button();
            btnPunto7 = new Button();
            btnPunto8 = new Button();
            btnVerLog = new Button();
            txtVisorBD = new TextBox();
            txtVisorExcepciones = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // btnPunto1
            // 
            btnPunto1.Location = new Point(12, 11);
            btnPunto1.Name = "btnPunto1";
            btnPunto1.Size = new Size(75, 23);
            btnPunto1.TabIndex = 0;
            btnPunto1.Text = "PUNTO1";
            btnPunto1.UseVisualStyleBackColor = true;
            btnPunto1.Click += btnPunto1_Click;
            // 
            // btnPunto2
            // 
            btnPunto2.Location = new Point(94, 11);
            btnPunto2.Name = "btnPunto2";
            btnPunto2.Size = new Size(75, 23);
            btnPunto2.TabIndex = 1;
            btnPunto2.Text = "PUNTO2";
            btnPunto2.UseVisualStyleBackColor = true;
            btnPunto2.Click += btnPunto2_Click;
            // 
            // btnPunto3
            // 
            btnPunto3.Location = new Point(175, 11);
            btnPunto3.Name = "btnPunto3";
            btnPunto3.Size = new Size(75, 23);
            btnPunto3.TabIndex = 2;
            btnPunto3.Text = "PUNTO3";
            btnPunto3.UseVisualStyleBackColor = true;
            btnPunto3.Click += btnPunto3_Click;
            // 
            // btnPunto4
            // 
            btnPunto4.Location = new Point(256, 11);
            btnPunto4.Name = "btnPunto4";
            btnPunto4.Size = new Size(75, 23);
            btnPunto4.TabIndex = 3;
            btnPunto4.Text = "PUNTO4";
            btnPunto4.UseVisualStyleBackColor = true;
            btnPunto4.Click += btnPunto4_Click;
            // 
            // btnPunto5
            // 
            btnPunto5.Location = new Point(12, 232);
            btnPunto5.Name = "btnPunto5";
            btnPunto5.Size = new Size(75, 23);
            btnPunto5.TabIndex = 4;
            btnPunto5.Text = "PUNTO5";
            btnPunto5.UseVisualStyleBackColor = true;
            btnPunto5.Click += btnPunto5_Click;
            // 
            // btnPunto6
            // 
            btnPunto6.Location = new Point(94, 232);
            btnPunto6.Name = "btnPunto6";
            btnPunto6.Size = new Size(75, 23);
            btnPunto6.TabIndex = 5;
            btnPunto6.Text = "PUNTO6";
            btnPunto6.UseVisualStyleBackColor = true;
            btnPunto6.Click += btnPunto6_Click;
            // 
            // btnPunto7
            // 
            btnPunto7.Location = new Point(175, 232);
            btnPunto7.Name = "btnPunto7";
            btnPunto7.Size = new Size(75, 23);
            btnPunto7.TabIndex = 6;
            btnPunto7.Text = "PUNTO7";
            btnPunto7.UseVisualStyleBackColor = true;
            btnPunto7.Click += btnPunto7_Click;
            // 
            // btnPunto8
            // 
            btnPunto8.Location = new Point(256, 232);
            btnPunto8.Name = "btnPunto8";
            btnPunto8.Size = new Size(75, 23);
            btnPunto8.TabIndex = 7;
            btnPunto8.Text = "PUNTO8";
            btnPunto8.UseVisualStyleBackColor = true;
            btnPunto8.Click += btnPunto8_Click;
            // 
            // btnVerLog
            // 
            btnVerLog.Location = new Point(337, 232);
            btnVerLog.Name = "btnVerLog";
            btnVerLog.Size = new Size(179, 23);
            btnVerLog.TabIndex = 8;
            btnVerLog.Text = "ver log excepciones";
            btnVerLog.UseVisualStyleBackColor = true;
            btnVerLog.Click += btnVerLog_Click;
            // 
            // txtVisorBD
            // 
            txtVisorBD.Location = new Point(12, 40);
            txtVisorBD.Multiline = true;
            txtVisorBD.Name = "txtVisorBD";
            txtVisorBD.Size = new Size(317, 179);
            txtVisorBD.TabIndex = 9;
            // 
            // txtVisorExcepciones
            // 
            txtVisorExcepciones.Location = new Point(335, 40);
            txtVisorExcepciones.Multiline = true;
            txtVisorExcepciones.Name = "txtVisorExcepciones";
            txtVisorExcepciones.Size = new Size(205, 179);
            txtVisorExcepciones.TabIndex = 10;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Final
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 267);
            Controls.Add(txtVisorExcepciones);
            Controls.Add(txtVisorBD);
            Controls.Add(btnVerLog);
            Controls.Add(btnPunto8);
            Controls.Add(btnPunto7);
            Controls.Add(btnPunto6);
            Controls.Add(btnPunto5);
            Controls.Add(btnPunto4);
            Controls.Add(btnPunto3);
            Controls.Add(btnPunto2);
            Controls.Add(btnPunto1);
            Name = "Final";
            Text = "Frm";
            Load += Final_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPunto1;
        private Button btnPunto2;
        private Button btnPunto3;
        private Button btnPunto4;
        private Button btnPunto5;
        private Button btnPunto6;
        private Button btnPunto7;
        private Button btnPunto8;
        private Button btnVerLog;
        private TextBox txtVisorBD;
        private TextBox txtVisorExcepciones;
        private OpenFileDialog openFileDialog1;
    }
}