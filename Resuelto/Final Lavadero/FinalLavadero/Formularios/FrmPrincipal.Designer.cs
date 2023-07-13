namespace Formularios
{
    partial class FrmPrincipal
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
            groupBox2 = new GroupBox();
            lstAutos = new ListBox();
            groupBox1 = new GroupBox();
            txtAutosLog = new TextBox();
            menuStrip1 = new MenuStrip();
            autosToolStripMenuItem = new ToolStripMenuItem();
            listadoToolStripMenuItem = new ToolStripMenuItem();
            verLogAutosToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lstAutos);
            groupBox2.Location = new Point(102, 297);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(791, 224);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Autos en BD";
            // 
            // lstAutos
            // 
            lstAutos.Dock = DockStyle.Fill;
            lstAutos.FormattingEnabled = true;
            lstAutos.ItemHeight = 15;
            lstAutos.Location = new Point(3, 19);
            lstAutos.Name = "lstAutos";
            lstAutos.SelectionMode = SelectionMode.None;
            lstAutos.Size = new Size(785, 202);
            lstAutos.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtAutosLog);
            groupBox1.Location = new Point(102, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(791, 224);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Log Autos";
            // 
            // txtAutosLog
            // 
            txtAutosLog.Dock = DockStyle.Fill;
            txtAutosLog.Location = new Point(3, 19);
            txtAutosLog.Multiline = true;
            txtAutosLog.Name = "txtAutosLog";
            txtAutosLog.Size = new Size(785, 202);
            txtAutosLog.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { autosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1017, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // autosToolStripMenuItem
            // 
            autosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listadoToolStripMenuItem, verLogAutosToolStripMenuItem });
            autosToolStripMenuItem.Name = "autosToolStripMenuItem";
            autosToolStripMenuItem.Size = new Size(50, 20);
            autosToolStripMenuItem.Text = "Autos";
            // 
            // listadoToolStripMenuItem
            // 
            listadoToolStripMenuItem.Name = "listadoToolStripMenuItem";
            listadoToolStripMenuItem.Size = new Size(180, 22);
            listadoToolStripMenuItem.Text = "Listado";
            listadoToolStripMenuItem.Click += listadoToolStripMenuItem_Click;
            // 
            // verLogAutosToolStripMenuItem
            // 
            verLogAutosToolStripMenuItem.Name = "verLogAutosToolStripMenuItem";
            verLogAutosToolStripMenuItem.Size = new Size(180, 22);
            verLogAutosToolStripMenuItem.Text = "Ver Log Autos";
            verLogAutosToolStripMenuItem.Click += verLogAutosToolStripMenuItem_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 527);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            Name = "FrmPrincipal";
            Text = "FrmPrincipal";
            Load += FrmPrincipal_Load;
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private ListBox lstAutos;
        private GroupBox groupBox1;
        private TextBox txtAutosLog;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem autosToolStripMenuItem;
        private ToolStripMenuItem listadoToolStripMenuItem;
        private ToolStripMenuItem verLogAutosToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
    }
}