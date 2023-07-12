namespace FormularioLav
{
    partial class FrmAltaLavadero
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
            txtVehiculo = new TextBox();
            btnCancelar = new Button();
            btnAceptar = new Button();
            cboTipo = new ComboBox();
            cboMarca = new ComboBox();
            lblPatente = new Label();
            lblTipo = new Label();
            lblMarca = new Label();
            SuspendLayout();
            // 
            // txtVehiculo
            // 
            txtVehiculo.Location = new Point(125, 139);
            txtVehiculo.Name = "txtVehiculo";
            txtVehiculo.Size = new Size(125, 23);
            txtVehiculo.TabIndex = 0;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(177, 220);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(113, 23);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(60, 220);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(111, 23);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Agregar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // cboTipo
            // 
            cboTipo.AccessibleDescription = "";
            cboTipo.AccessibleName = "";
            cboTipo.FormattingEnabled = true;
            cboTipo.Location = new Point(125, 24);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(121, 23);
            cboTipo.TabIndex = 3;
            cboTipo.Text = "Seleccione";
            cboTipo.SelectionChangeCommitted += cboTipo_SelectionChangeCommitted;
            // 
            // cboMarca
            // 
            cboMarca.FormattingEnabled = true;
            cboMarca.Location = new Point(125, 70);
            cboMarca.Name = "cboMarca";
            cboMarca.Size = new Size(121, 23);
            cboMarca.TabIndex = 4;
            // 
            // lblPatente
            // 
            lblPatente.AutoSize = true;
            lblPatente.Location = new Point(60, 142);
            lblPatente.Name = "lblPatente";
            lblPatente.Size = new Size(50, 15);
            lblPatente.TabIndex = 5;
            lblPatente.Text = "Patente:";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(77, 24);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(33, 15);
            lblTipo.TabIndex = 7;
            lblTipo.Text = "Tipo:";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(67, 73);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(43, 15);
            lblMarca.TabIndex = 8;
            lblMarca.Text = "Marca:";
            // 
            // LavaderoModificacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 271);
            ControlBox = false;
            Controls.Add(lblMarca);
            Controls.Add(lblTipo);
            Controls.Add(lblPatente);
            Controls.Add(cboMarca);
            Controls.Add(cboTipo);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Controls.Add(txtVehiculo);
            Name = "LavaderoModificacion";
            ShowIcon = false;
            Text = "LavaderoModificacion";
            Load += LavaderoModificacion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtVehiculo;
        private Button btnCancelar;
        private Button btnAceptar;
        private ComboBox cboTipo;
        private ComboBox cboMarca;
        private Label lblPatente;
        private Label lblTipo;
        private Label lblMarca;
    }
}