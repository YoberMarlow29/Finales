namespace Formulario
{
    partial class FrmPasajeroTask
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
            lstVisorTask = new ListBox();
            btnCancelarTask = new Button();
            btnIniciarTask = new Button();
            SuspendLayout();
            // 
            // lstVisorTask
            // 
            lstVisorTask.FormattingEnabled = true;
            lstVisorTask.ItemHeight = 15;
            lstVisorTask.Location = new Point(14, 12);
            lstVisorTask.Name = "lstVisorTask";
            lstVisorTask.Size = new Size(349, 394);
            lstVisorTask.TabIndex = 13;
            // 
            // btnCancelarTask
            // 
            btnCancelarTask.BackColor = Color.Red;
            btnCancelarTask.Font = new Font("Javanese Text", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelarTask.Location = new Point(369, 236);
            btnCancelarTask.Name = "btnCancelarTask";
            btnCancelarTask.Size = new Size(286, 46);
            btnCancelarTask.TabIndex = 15;
            btnCancelarTask.Text = "Cancelar Task";
            btnCancelarTask.UseVisualStyleBackColor = false;
            btnCancelarTask.Click += btnCancelarTask_Click;
            // 
            // btnIniciarTask
            // 
            btnIniciarTask.BackColor = Color.LawnGreen;
            btnIniciarTask.Font = new Font("Javanese Text", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnIniciarTask.Location = new Point(369, 136);
            btnIniciarTask.Name = "btnIniciarTask";
            btnIniciarTask.Size = new Size(286, 46);
            btnIniciarTask.TabIndex = 14;
            btnIniciarTask.Text = "Iniciar Task";
            btnIniciarTask.UseVisualStyleBackColor = false;
            btnIniciarTask.Click += btnIniciarTask_Click;
            // 
            // FrmPasajeroTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 418);
            Controls.Add(lstVisorTask);
            Controls.Add(btnCancelarTask);
            Controls.Add(btnIniciarTask);
            MaximumSize = new Size(685, 457);
            MinimumSize = new Size(685, 457);
            Name = "FrmPasajeroTask";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPasajeroTask";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstVisorTask;
        private Button btnCancelarTask;
        private Button btnIniciarTask;
    }
}