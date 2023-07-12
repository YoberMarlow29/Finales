namespace Formularios
{
    partial class FrmListado
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
            btnEliminar = new Button();
            btnAgregar = new Button();
            btnModificar = new Button();
            lstListado = new ListBox();
            SuspendLayout();
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(629, 395);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(159, 43);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "&Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(321, 395);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(159, 43);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "&Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(12, 395);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(159, 43);
            btnModificar.TabIndex = 5;
            btnModificar.Text = "&Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // lstListado
            // 
            lstListado.FormattingEnabled = true;
            lstListado.ItemHeight = 15;
            lstListado.Location = new Point(12, 12);
            lstListado.Name = "lstListado";
            lstListado.Size = new Size(776, 364);
            lstListado.TabIndex = 4;
            // 
            // FrmListado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(btnModificar);
            Controls.Add(lstListado);
            Name = "FrmListado";
            Text = "FrmListado";
            Load += FrmListado_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnEliminar;
        private Button btnAgregar;
        private Button btnModificar;
        private ListBox lstListado;
    }
}