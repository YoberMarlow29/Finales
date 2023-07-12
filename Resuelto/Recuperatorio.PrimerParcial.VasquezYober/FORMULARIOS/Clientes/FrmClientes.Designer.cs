namespace FORMULARIOS
{
    partial class FrmClientes
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
            dataGridClientes = new DataGridView();
            textBox1 = new TextBox();
            btnAgregarCliente = new Button();
            btnModificarCliente = new Button();
            btnBajaCliente = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridClientes).BeginInit();
            SuspendLayout();
            // 
            // dataGridClientes
            // 
            dataGridClientes.AllowUserToAddRows = false;
            dataGridClientes.AllowUserToDeleteRows = false;
            dataGridClientes.AllowUserToResizeRows = false;
            dataGridClientes.Anchor = AnchorStyles.None;
            dataGridClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridClientes.EnableHeadersVisualStyles = false;
            dataGridClientes.Location = new Point(12, 79);
            dataGridClientes.MultiSelect = false;
            dataGridClientes.Name = "dataGridClientes";
            dataGridClientes.ReadOnly = true;
            dataGridClientes.RowHeadersVisible = false;
            dataGridClientes.RowTemplate.Height = 25;
            dataGridClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridClientes.Size = new Size(913, 493);
            dataGridClientes.TabIndex = 9;
            dataGridClientes.TabStop = false;
            dataGridClientes.VirtualMode = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(288, 23);
            textBox1.TabIndex = 10;
            textBox1.Text = "buscar cliente...\r\n";
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.Location = new Point(12, 578);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(75, 23);
            btnAgregarCliente.TabIndex = 11;
            btnAgregarCliente.Text = "ALTA";
            btnAgregarCliente.UseVisualStyleBackColor = true;
            btnAgregarCliente.Click += btnAgregarCliente_Click;
            // 
            // btnModificarCliente
            // 
            btnModificarCliente.Location = new Point(193, 578);
            btnModificarCliente.Name = "btnModificarCliente";
            btnModificarCliente.Size = new Size(80, 23);
            btnModificarCliente.TabIndex = 12;
            btnModificarCliente.Text = "MODIFICAR";
            btnModificarCliente.UseVisualStyleBackColor = true;
            btnModificarCliente.Click += btnModificarCliente_Click;
            // 
            // btnBajaCliente
            // 
            btnBajaCliente.Location = new Point(103, 578);
            btnBajaCliente.Name = "btnBajaCliente";
            btnBajaCliente.Size = new Size(75, 23);
            btnBajaCliente.TabIndex = 13;
            btnBajaCliente.Text = "BAJA";
            btnBajaCliente.UseVisualStyleBackColor = true;
            btnBajaCliente.Click += btnBajaCliente_Click;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 617);
            Controls.Add(btnBajaCliente);
            Controls.Add(btnModificarCliente);
            Controls.Add(btnAgregarCliente);
            Controls.Add(textBox1);
            Controls.Add(dataGridClientes);
            Name = "FrmClientes";
            Text = "FrmClientes";
            Load += FrmClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridClientes;
        private TextBox textBox1;
        private Button btnAgregarCliente;
        private Button btnModificarCliente;
        private Button btnBajaCliente;
    }
}