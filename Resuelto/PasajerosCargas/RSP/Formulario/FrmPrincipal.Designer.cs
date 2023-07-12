namespace Formulario
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
            groupBox3 = new GroupBox();
            lstVisor = new ListBox();
            lblMensaje = new Label();
            groupBox2 = new GroupBox();
            btnPasajerosCRUD = new Button();
            btnPasajerosTask = new Button();
            groupBox1 = new GroupBox();
            btnTransportePasajeros = new Button();
            txtPasajeros = new TextBox();
            btnTransporteCarga = new Button();
            txtCargas = new TextBox();
            btnEventosPasajeros = new Button();
            btnEventosCargas = new Button();
            btnCargaDeserializar = new Button();
            btnPasajeroSerializar = new Button();
            btnCargaSerializar = new Button();
            btnPasajeroDeserializar = new Button();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lstVisor);
            groupBox3.Controls.Add(lblMensaje);
            groupBox3.Location = new Point(649, 27);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(432, 541);
            groupBox3.TabIndex = 20;
            groupBox3.TabStop = false;
            groupBox3.Text = "Visor Deserialización";
            // 
            // lstVisor
            // 
            lstVisor.FormattingEnabled = true;
            lstVisor.ItemHeight = 15;
            lstVisor.Location = new Point(22, 22);
            lstVisor.Name = "lstVisor";
            lstVisor.Size = new Size(389, 439);
            lstVisor.TabIndex = 11;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoEllipsis = true;
            lblMensaje.AutoSize = true;
            lblMensaje.BorderStyle = BorderStyle.FixedSingle;
            lblMensaje.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblMensaje.Location = new Point(22, 488);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(360, 29);
            lblMensaje.TabIndex = 10;
            lblMensaje.Text = "mensajes serialización/deserialización";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnPasajerosCRUD);
            groupBox2.Controls.Add(btnPasajerosTask);
            groupBox2.Location = new Point(12, 442);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(631, 126);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Parte 2";
            // 
            // btnPasajerosCRUD
            // 
            btnPasajerosCRUD.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnPasajerosCRUD.Location = new Point(6, 42);
            btnPasajerosCRUD.Name = "btnPasajerosCRUD";
            btnPasajerosCRUD.Size = new Size(290, 43);
            btnPasajerosCRUD.TabIndex = 13;
            btnPasajerosCRUD.Text = "Pasajero BD CRUD";
            btnPasajerosCRUD.UseVisualStyleBackColor = true;
            btnPasajerosCRUD.Click += btnPasajerosCRUD_Click;
            // 
            // btnPasajerosTask
            // 
            btnPasajerosTask.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnPasajerosTask.Location = new Point(335, 42);
            btnPasajerosTask.Name = "btnPasajerosTask";
            btnPasajerosTask.Size = new Size(290, 43);
            btnPasajerosTask.TabIndex = 14;
            btnPasajerosTask.Text = "Pasajero BD Task";
            btnPasajerosTask.UseVisualStyleBackColor = true;
            btnPasajerosTask.Click += btnPasajerosTask_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnTransportePasajeros);
            groupBox1.Controls.Add(txtPasajeros);
            groupBox1.Controls.Add(btnTransporteCarga);
            groupBox1.Controls.Add(txtCargas);
            groupBox1.Controls.Add(btnEventosPasajeros);
            groupBox1.Controls.Add(btnEventosCargas);
            groupBox1.Controls.Add(btnCargaDeserializar);
            groupBox1.Controls.Add(btnPasajeroSerializar);
            groupBox1.Controls.Add(btnCargaSerializar);
            groupBox1.Controls.Add(btnPasajeroDeserializar);
            groupBox1.Location = new Point(12, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(631, 409);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Parte 1";
            // 
            // btnTransportePasajeros
            // 
            btnTransportePasajeros.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnTransportePasajeros.Location = new Point(6, 22);
            btnTransportePasajeros.Name = "btnTransportePasajeros";
            btnTransportePasajeros.Size = new Size(290, 43);
            btnTransportePasajeros.TabIndex = 0;
            btnTransportePasajeros.Text = "Transporte de pasajeros";
            btnTransportePasajeros.UseVisualStyleBackColor = true;
            btnTransportePasajeros.Click += btnTransportePasajeros_Click;
            // 
            // txtPasajeros
            // 
            txtPasajeros.Location = new Point(6, 71);
            txtPasajeros.Multiline = true;
            txtPasajeros.Name = "txtPasajeros";
            txtPasajeros.Size = new Size(290, 119);
            txtPasajeros.TabIndex = 1;
            // 
            // btnTransporteCarga
            // 
            btnTransporteCarga.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnTransporteCarga.Location = new Point(335, 22);
            btnTransporteCarga.Name = "btnTransporteCarga";
            btnTransporteCarga.Size = new Size(290, 43);
            btnTransporteCarga.TabIndex = 2;
            btnTransporteCarga.Text = "Transporte de cargas";
            btnTransporteCarga.UseVisualStyleBackColor = true;
            btnTransporteCarga.Click += btnTransporteCarga_Click;
            // 
            // txtCargas
            // 
            txtCargas.Location = new Point(335, 71);
            txtCargas.Multiline = true;
            txtCargas.Name = "txtCargas";
            txtCargas.Size = new Size(290, 119);
            txtCargas.TabIndex = 3;
            // 
            // btnEventosPasajeros
            // 
            btnEventosPasajeros.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEventosPasajeros.Location = new Point(6, 209);
            btnEventosPasajeros.Name = "btnEventosPasajeros";
            btnEventosPasajeros.Size = new Size(290, 43);
            btnEventosPasajeros.TabIndex = 4;
            btnEventosPasajeros.Text = "Transporte de pasajeros eventos";
            btnEventosPasajeros.UseVisualStyleBackColor = true;
            btnEventosPasajeros.Click += btnEventosPasajeros_Click;
            // 
            // btnEventosCargas
            // 
            btnEventosCargas.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEventosCargas.Location = new Point(335, 209);
            btnEventosCargas.Name = "btnEventosCargas";
            btnEventosCargas.Size = new Size(290, 43);
            btnEventosCargas.TabIndex = 5;
            btnEventosCargas.Text = "Transporte de cargas eventos";
            btnEventosCargas.UseVisualStyleBackColor = true;
            btnEventosCargas.Click += btnEventosCargas_Click;
            // 
            // btnCargaDeserializar
            // 
            btnCargaDeserializar.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCargaDeserializar.Location = new Point(335, 332);
            btnCargaDeserializar.Name = "btnCargaDeserializar";
            btnCargaDeserializar.Size = new Size(290, 43);
            btnCargaDeserializar.TabIndex = 9;
            btnCargaDeserializar.Text = "Carga Deserializar (XML)";
            btnCargaDeserializar.UseVisualStyleBackColor = true;
            btnCargaDeserializar.Click += btnCargaDeserializar_Click;
            // 
            // btnPasajeroSerializar
            // 
            btnPasajeroSerializar.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnPasajeroSerializar.Location = new Point(6, 283);
            btnPasajeroSerializar.Name = "btnPasajeroSerializar";
            btnPasajeroSerializar.Size = new Size(290, 43);
            btnPasajeroSerializar.TabIndex = 6;
            btnPasajeroSerializar.Text = "Pasajero Serializar (JSON)";
            btnPasajeroSerializar.UseVisualStyleBackColor = true;
            btnPasajeroSerializar.Click += btnPasajeroSerializar_Click;
            // 
            // btnCargaSerializar
            // 
            btnCargaSerializar.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCargaSerializar.Location = new Point(335, 283);
            btnCargaSerializar.Name = "btnCargaSerializar";
            btnCargaSerializar.Size = new Size(290, 43);
            btnCargaSerializar.TabIndex = 8;
            btnCargaSerializar.Text = "Carga Serializar (XML)";
            btnCargaSerializar.UseVisualStyleBackColor = true;
            btnCargaSerializar.Click += btnCargaSerializar_Click;
            // 
            // btnPasajeroDeserializar
            // 
            btnPasajeroDeserializar.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnPasajeroDeserializar.Location = new Point(6, 332);
            btnPasajeroDeserializar.Name = "btnPasajeroDeserializar";
            btnPasajeroDeserializar.Size = new Size(290, 43);
            btnPasajeroDeserializar.TabIndex = 7;
            btnPasajeroDeserializar.Text = "Pasajero Deserializar (JSON)";
            btnPasajeroDeserializar.UseVisualStyleBackColor = true;
            btnPasajeroDeserializar.Click += btnPasajeroDeserializar_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 595);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximumSize = new Size(1109, 634);
            MinimumSize = new Size(1109, 634);
            Name = "FrmPrincipal";
            Text = "Recuperatorio Segundo Parcial";
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox3;
        private ListBox lstVisor;
        private Label lblMensaje;
        private GroupBox groupBox2;
        private Button btnPasajerosCRUD;
        private Button btnPasajerosTask;
        private GroupBox groupBox1;
        private Button btnTransportePasajeros;
        private TextBox txtPasajeros;
        private Button btnTransporteCarga;
        private TextBox txtCargas;
        private Button btnEventosPasajeros;
        private Button btnEventosCargas;
        private Button btnCargaDeserializar;
        private Button btnPasajeroSerializar;
        private Button btnCargaSerializar;
        private Button btnPasajeroDeserializar;
    }
}