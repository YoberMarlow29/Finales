namespace FormularioLav
{
    partial class FrmLavadero
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
            btnBorrar = new Button();
            btnAgregar = new Button();
            btnOrdenarMarca = new Button();
            btnOrdenarPatente = new Button();
            dgtLavadero = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgtLavadero).BeginInit();
            SuspendLayout();
            // 
            // btnBorrar
            // 
            btnBorrar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnBorrar.Location = new Point(471, 58);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(52, 40);
            btnBorrar.TabIndex = 0;
            btnBorrar.Text = "-";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.Location = new Point(471, 12);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(52, 40);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "+";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnOrdenarMarca
            // 
            btnOrdenarMarca.Location = new Point(334, 325);
            btnOrdenarMarca.Name = "btnOrdenarMarca";
            btnOrdenarMarca.Size = new Size(118, 23);
            btnOrdenarMarca.TabIndex = 3;
            btnOrdenarMarca.Text = "Ordenar por marca";
            btnOrdenarMarca.UseVisualStyleBackColor = true;
            btnOrdenarMarca.Click += btnOrdenarMarca_Click;
            // 
            // btnOrdenarPatente
            // 
            btnOrdenarPatente.Location = new Point(12, 325);
            btnOrdenarPatente.Name = "btnOrdenarPatente";
            btnOrdenarPatente.Size = new Size(129, 23);
            btnOrdenarPatente.TabIndex = 4;
            btnOrdenarPatente.Text = "Ordenar por patente";
            btnOrdenarPatente.UseVisualStyleBackColor = true;
            btnOrdenarPatente.Click += btnOrdenarPatente_Click;
            // 
            // dgtLavadero
            // 
            dgtLavadero.AllowUserToAddRows = false;
            dgtLavadero.AllowUserToDeleteRows = false;
            dgtLavadero.AllowUserToResizeRows = false;
            dgtLavadero.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgtLavadero.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgtLavadero.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgtLavadero.EnableHeadersVisualStyles = false;
            dgtLavadero.Location = new Point(12, 22);
            dgtLavadero.MultiSelect = false;
            dgtLavadero.Name = "dgtLavadero";
            dgtLavadero.ReadOnly = true;
            dgtLavadero.RowHeadersVisible = false;
            dgtLavadero.RowTemplate.Height = 25;
            dgtLavadero.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgtLavadero.Size = new Size(453, 283);
            dgtLavadero.TabIndex = 10;
            dgtLavadero.TabStop = false;
            dgtLavadero.VirtualMode = true;
            // 
            // FrmLavadero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 410);
            Controls.Add(dgtLavadero);
            Controls.Add(btnOrdenarPatente);
            Controls.Add(btnOrdenarMarca);
            Controls.Add(btnAgregar);
            Controls.Add(btnBorrar);
            Name = "FrmLavadero";
            Text = "Lavadero";
            Load += FrmLavadero_Load;
            ((System.ComponentModel.ISupportInitialize)dgtLavadero).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnBorrar;
        private Button btnAgregar;
        private Button btnOrdenarMarca;
        private Button btnOrdenarPatente;
        private DataGridView dgtLavadero;
    }
}