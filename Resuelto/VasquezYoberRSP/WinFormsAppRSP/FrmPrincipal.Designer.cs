namespace WinFormsAppRSP
{
    partial class FrmPrincipal
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
            btnHilos = new Button();
            btnDeserializar = new Button();
            btnSerializar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            groupBox2 = new GroupBox();
            lstDesaprobados = new ListBox();
            groupBox3 = new GroupBox();
            lstAprobados = new ListBox();
            groupBox4 = new GroupBox();
            lstPromocionados = new ListBox();
            groupBox1 = new GroupBox();
            lstTodos = new ListBox();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnHilos
            // 
            btnHilos.BackColor = Color.PeachPuff;
            btnHilos.Location = new Point(908, 206);
            btnHilos.Name = "btnHilos";
            btnHilos.Size = new Size(75, 23);
            btnHilos.TabIndex = 20;
            btnHilos.Text = "Hilos";
            btnHilos.UseVisualStyleBackColor = false;
            // 
            // btnDeserializar
            // 
            btnDeserializar.BackColor = Color.Fuchsia;
            btnDeserializar.Location = new Point(908, 166);
            btnDeserializar.Name = "btnDeserializar";
            btnDeserializar.Size = new Size(75, 23);
            btnDeserializar.TabIndex = 19;
            btnDeserializar.Text = "Deserializar";
            btnDeserializar.UseVisualStyleBackColor = false;
            // 
            // btnSerializar
            // 
            btnSerializar.BackColor = Color.FromArgb(0, 192, 0);
            btnSerializar.Location = new Point(908, 137);
            btnSerializar.Name = "btnSerializar";
            btnSerializar.Size = new Size(75, 23);
            btnSerializar.TabIndex = 18;
            btnSerializar.Text = "Serializar";
            btnSerializar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Tomato;
            btnEliminar.Location = new Point(908, 97);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 17;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(255, 255, 128);
            btnModificar.Location = new Point(908, 68);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 16;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(128, 255, 128);
            btnAgregar.Location = new Point(908, 39);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 15;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lstDesaprobados);
            groupBox2.Location = new Point(19, 235);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(327, 182);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Desaprobados";
            // 
            // lstDesaprobados
            // 
            lstDesaprobados.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            lstDesaprobados.ForeColor = Color.Red;
            lstDesaprobados.FormattingEnabled = true;
            lstDesaprobados.ItemHeight = 12;
            lstDesaprobados.Location = new Point(6, 22);
            lstDesaprobados.Name = "lstDesaprobados";
            lstDesaprobados.SelectionMode = SelectionMode.None;
            lstDesaprobados.Size = new Size(308, 136);
            lstDesaprobados.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lstAprobados);
            groupBox3.Location = new Point(360, 235);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(324, 182);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Aprobados";
            // 
            // lstAprobados
            // 
            lstAprobados.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            lstAprobados.FormattingEnabled = true;
            lstAprobados.ItemHeight = 12;
            lstAprobados.Location = new Point(6, 22);
            lstAprobados.Name = "lstAprobados";
            lstAprobados.SelectionMode = SelectionMode.None;
            lstAprobados.Size = new Size(308, 136);
            lstAprobados.TabIndex = 2;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lstPromocionados);
            groupBox4.Location = new Point(690, 235);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(324, 182);
            groupBox4.TabIndex = 13;
            groupBox4.TabStop = false;
            groupBox4.Text = "Promocionados";
            // 
            // lstPromocionados
            // 
            lstPromocionados.BackColor = SystemColors.Window;
            lstPromocionados.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            lstPromocionados.ForeColor = Color.Blue;
            lstPromocionados.FormattingEnabled = true;
            lstPromocionados.ItemHeight = 12;
            lstPromocionados.Location = new Point(6, 22);
            lstPromocionados.Name = "lstPromocionados";
            lstPromocionados.SelectionMode = SelectionMode.None;
            lstPromocionados.Size = new Size(308, 136);
            lstPromocionados.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lstTodos);
            groupBox1.Location = new Point(25, 17);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(845, 212);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Todos";
            // 
            // lstTodos
            // 
            lstTodos.FormattingEnabled = true;
            lstTodos.ItemHeight = 15;
            lstTodos.Location = new Point(6, 22);
            lstTodos.Name = "lstTodos";
            lstTodos.Size = new Size(833, 169);
            lstTodos.TabIndex = 0;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1033, 435);
            Controls.Add(btnHilos);
            Controls.Add(btnDeserializar);
            Controls.Add(btnSerializar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox4);
            Controls.Add(groupBox1);
            Name = "FrmPrincipal";
            Text = "Form1";
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnHilos;
        private Button btnDeserializar;
        private Button btnSerializar;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private GroupBox groupBox2;
        private ListBox lstDesaprobados;
        private GroupBox groupBox3;
        private ListBox lstAprobados;
        private GroupBox groupBox4;
        private ListBox lstPromocionados;
        private GroupBox groupBox1;
        private ListBox lstTodos;
    }
}