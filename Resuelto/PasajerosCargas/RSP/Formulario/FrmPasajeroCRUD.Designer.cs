namespace Formulario
{
    partial class FrmPasajeroCRUD
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
            lstVisorCRUD = new ListBox();
            gpbCRUD = new GroupBox();
            btnEliminar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnAgregar = new Button();
            btnModificar = new Button();
            txtDni = new TextBox();
            txtNombre = new TextBox();
            txtEquipaje = new TextBox();
            gpbCRUD.SuspendLayout();
            SuspendLayout();
            // 
            // lstVisorCRUD
            // 
            lstVisorCRUD.FormattingEnabled = true;
            lstVisorCRUD.ItemHeight = 15;
            lstVisorCRUD.Location = new Point(12, 12);
            lstVisorCRUD.Name = "lstVisorCRUD";
            lstVisorCRUD.Size = new Size(349, 394);
            lstVisorCRUD.TabIndex = 1;
            lstVisorCRUD.SelectedIndexChanged += lstVisorCRUD_SelectedIndexChanged;
            // 
            // gpbCRUD
            // 
            gpbCRUD.Controls.Add(btnEliminar);
            gpbCRUD.Controls.Add(label1);
            gpbCRUD.Controls.Add(label2);
            gpbCRUD.Controls.Add(label3);
            gpbCRUD.Controls.Add(btnAgregar);
            gpbCRUD.Controls.Add(btnModificar);
            gpbCRUD.Controls.Add(txtDni);
            gpbCRUD.Controls.Add(txtNombre);
            gpbCRUD.Controls.Add(txtEquipaje);
            gpbCRUD.Location = new Point(399, 12);
            gpbCRUD.Name = "gpbCRUD";
            gpbCRUD.Size = new Size(337, 394);
            gpbCRUD.TabIndex = 2;
            gpbCRUD.TabStop = false;
            gpbCRUD.Text = "Pasajero CRUD";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.Font = new Font("Javanese Text", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.Location = new Point(23, 342);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(286, 46);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(23, 24);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 1;
            label1.Text = "DNI:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(23, 89);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 2;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(23, 158);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 3;
            label3.Text = "Equipaje:";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.LawnGreen;
            btnAgregar.Font = new Font("Javanese Text", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.Location = new Point(23, 238);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(286, 46);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.Yellow;
            btnModificar.Font = new Font("Javanese Text", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificar.Location = new Point(23, 290);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(286, 46);
            btnModificar.TabIndex = 5;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // txtDni
            // 
            txtDni.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDni.Location = new Point(23, 47);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(286, 29);
            txtDni.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(23, 112);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(286, 29);
            txtNombre.TabIndex = 7;
            // 
            // txtEquipaje
            // 
            txtEquipaje.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtEquipaje.Location = new Point(23, 181);
            txtEquipaje.Name = "txtEquipaje";
            txtEquipaje.Size = new Size(286, 29);
            txtEquipaje.TabIndex = 8;
            // 
            // FrmPasajeroCRUD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 418);
            Controls.Add(lstVisorCRUD);
            Controls.Add(gpbCRUD);
            MaximumSize = new Size(764, 457);
            MinimumSize = new Size(764, 457);
            Name = "FrmPasajeroCRUD";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPasajeroCRUD";
            Load += FrmPasajeroCRUD_Load;
            gpbCRUD.ResumeLayout(false);
            gpbCRUD.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstVisorCRUD;
        private GroupBox gpbCRUD;
        private Button btnEliminar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnAgregar;
        private Button btnModificar;
        private TextBox txtDni;
        private TextBox txtNombre;
        private TextBox txtEquipaje;
    }
}