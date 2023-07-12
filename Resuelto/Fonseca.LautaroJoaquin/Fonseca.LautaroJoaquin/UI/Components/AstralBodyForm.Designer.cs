namespace UI.Components
{
    partial class AstralBodyForm
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
            this.astralBodyTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.starRadioButton = new System.Windows.Forms.RadioButton();
            this.planetRadioButton = new System.Windows.Forms.RadioButton();
            this.characteristicsGroupBox = new System.Windows.Forms.GroupBox();
            this.spectralTypeTextBox = new System.Windows.Forms.TextBox();
            this.satellitesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ringsCheckBox = new System.Windows.Forms.CheckBox();
            this.massNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.diameterNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.spectralTypeLabel = new System.Windows.Forms.Label();
            this.satellitesLabel = new System.Windows.Forms.Label();
            this.massLabel = new System.Windows.Forms.Label();
            this.diameterLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.astralBodyTypeGroupBox.SuspendLayout();
            this.characteristicsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.satellitesNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.massNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diameterNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // astralBodyTypeGroupBox
            // 
            this.astralBodyTypeGroupBox.Controls.Add(this.starRadioButton);
            this.astralBodyTypeGroupBox.Controls.Add(this.planetRadioButton);
            this.astralBodyTypeGroupBox.Location = new System.Drawing.Point(12, 12);
            this.astralBodyTypeGroupBox.Name = "astralBodyTypeGroupBox";
            this.astralBodyTypeGroupBox.Size = new System.Drawing.Size(126, 74);
            this.astralBodyTypeGroupBox.TabIndex = 0;
            this.astralBodyTypeGroupBox.TabStop = false;
            this.astralBodyTypeGroupBox.Text = "Tipo de Astro";
            // 
            // starRadioButton
            // 
            this.starRadioButton.AutoSize = true;
            this.starRadioButton.Location = new System.Drawing.Point(6, 50);
            this.starRadioButton.Name = "starRadioButton";
            this.starRadioButton.Size = new System.Drawing.Size(77, 21);
            this.starRadioButton.TabIndex = 1;
            this.starRadioButton.TabStop = true;
            this.starRadioButton.Text = "Estrella";
            this.starRadioButton.UseVisualStyleBackColor = true;
            this.starRadioButton.CheckedChanged += new System.EventHandler(this.starRadioButton_CheckedChanged);
            // 
            // planetRadioButton
            // 
            this.planetRadioButton.AutoSize = true;
            this.planetRadioButton.Location = new System.Drawing.Point(6, 23);
            this.planetRadioButton.Name = "planetRadioButton";
            this.planetRadioButton.Size = new System.Drawing.Size(76, 21);
            this.planetRadioButton.TabIndex = 0;
            this.planetRadioButton.TabStop = true;
            this.planetRadioButton.Text = "Planeta";
            this.planetRadioButton.UseVisualStyleBackColor = true;
            this.planetRadioButton.CheckedChanged += new System.EventHandler(this.planetRadioButton_CheckedChanged);
            // 
            // characteristicsGroupBox
            // 
            this.characteristicsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.characteristicsGroupBox.Controls.Add(this.spectralTypeTextBox);
            this.characteristicsGroupBox.Controls.Add(this.satellitesNumericUpDown);
            this.characteristicsGroupBox.Controls.Add(this.ringsCheckBox);
            this.characteristicsGroupBox.Controls.Add(this.massNumericUpDown);
            this.characteristicsGroupBox.Controls.Add(this.diameterNumericUpDown);
            this.characteristicsGroupBox.Controls.Add(this.nameTextBox);
            this.characteristicsGroupBox.Controls.Add(this.spectralTypeLabel);
            this.characteristicsGroupBox.Controls.Add(this.satellitesLabel);
            this.characteristicsGroupBox.Controls.Add(this.massLabel);
            this.characteristicsGroupBox.Controls.Add(this.diameterLabel);
            this.characteristicsGroupBox.Controls.Add(this.nameLabel);
            this.characteristicsGroupBox.Location = new System.Drawing.Point(144, 12);
            this.characteristicsGroupBox.Name = "characteristicsGroupBox";
            this.characteristicsGroupBox.Size = new System.Drawing.Size(282, 199);
            this.characteristicsGroupBox.TabIndex = 1;
            this.characteristicsGroupBox.TabStop = false;
            this.characteristicsGroupBox.Text = "Caracteristicas";
            // 
            // spectralTypeTextBox
            // 
            this.spectralTypeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spectralTypeTextBox.Location = new System.Drawing.Point(120, 166);
            this.spectralTypeTextBox.MaxLength = 50;
            this.spectralTypeTextBox.Name = "spectralTypeTextBox";
            this.spectralTypeTextBox.Size = new System.Drawing.Size(120, 24);
            this.spectralTypeTextBox.TabIndex = 12;
            // 
            // satellitesNumericUpDown
            // 
            this.satellitesNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.satellitesNumericUpDown.Location = new System.Drawing.Point(120, 137);
            this.satellitesNumericUpDown.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.satellitesNumericUpDown.Name = "satellitesNumericUpDown";
            this.satellitesNumericUpDown.Size = new System.Drawing.Size(120, 24);
            this.satellitesNumericUpDown.TabIndex = 11;
            // 
            // ringsCheckBox
            // 
            this.ringsCheckBox.AutoSize = true;
            this.ringsCheckBox.Location = new System.Drawing.Point(6, 110);
            this.ringsCheckBox.Name = "ringsCheckBox";
            this.ringsCheckBox.Size = new System.Drawing.Size(122, 21);
            this.ringsCheckBox.TabIndex = 10;
            this.ringsCheckBox.Text = "Tiene Anillos?";
            this.ringsCheckBox.UseVisualStyleBackColor = true;
            // 
            // massNumericUpDown
            // 
            this.massNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.massNumericUpDown.Location = new System.Drawing.Point(120, 80);
            this.massNumericUpDown.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.massNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.massNumericUpDown.Name = "massNumericUpDown";
            this.massNumericUpDown.Size = new System.Drawing.Size(120, 24);
            this.massNumericUpDown.TabIndex = 9;
            this.massNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // diameterNumericUpDown
            // 
            this.diameterNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.diameterNumericUpDown.Location = new System.Drawing.Point(120, 50);
            this.diameterNumericUpDown.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.diameterNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.diameterNumericUpDown.Name = "diameterNumericUpDown";
            this.diameterNumericUpDown.Size = new System.Drawing.Size(120, 24);
            this.diameterNumericUpDown.TabIndex = 8;
            this.diameterNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.Location = new System.Drawing.Point(120, 20);
            this.nameTextBox.MaxLength = 50;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(120, 24);
            this.nameTextBox.TabIndex = 7;
            // 
            // spectralTypeLabel
            // 
            this.spectralTypeLabel.AutoSize = true;
            this.spectralTypeLabel.Location = new System.Drawing.Point(6, 173);
            this.spectralTypeLabel.Name = "spectralTypeLabel";
            this.spectralTypeLabel.Size = new System.Drawing.Size(113, 17);
            this.spectralTypeLabel.TabIndex = 6;
            this.spectralTypeLabel.Text = "Tipo Espectral:";
            // 
            // satellitesLabel
            // 
            this.satellitesLabel.AutoSize = true;
            this.satellitesLabel.Location = new System.Drawing.Point(6, 144);
            this.satellitesLabel.Name = "satellitesLabel";
            this.satellitesLabel.Size = new System.Drawing.Size(74, 17);
            this.satellitesLabel.TabIndex = 5;
            this.satellitesLabel.Text = "Satelites:";
            // 
            // massLabel
            // 
            this.massLabel.AutoSize = true;
            this.massLabel.Location = new System.Drawing.Point(6, 87);
            this.massLabel.Name = "massLabel";
            this.massLabel.Size = new System.Drawing.Size(83, 17);
            this.massLabel.TabIndex = 2;
            this.massLabel.Text = "Masa (kg):";
            // 
            // diameterLabel
            // 
            this.diameterLabel.AutoSize = true;
            this.diameterLabel.Location = new System.Drawing.Point(6, 57);
            this.diameterLabel.Name = "diameterLabel";
            this.diameterLabel.Size = new System.Drawing.Size(108, 17);
            this.diameterLabel.TabIndex = 1;
            this.diameterLabel.Text = "Diametro (m):";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(6, 27);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(69, 17);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Nombre:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 96);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(126, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Guardar";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(12, 125);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(126, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancelar";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // AstralBodyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 221);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.characteristicsGroupBox);
            this.Controls.Add(this.astralBodyTypeGroupBox);
            this.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximumSize = new System.Drawing.Size(460, 260);
            this.Name = "AstralBodyForm";
            this.Text = "Creacion de Cuerpo Astral";
            this.astralBodyTypeGroupBox.ResumeLayout(false);
            this.astralBodyTypeGroupBox.PerformLayout();
            this.characteristicsGroupBox.ResumeLayout(false);
            this.characteristicsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.satellitesNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.massNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diameterNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox astralBodyTypeGroupBox;
        private RadioButton starRadioButton;
        private RadioButton planetRadioButton;
        private GroupBox characteristicsGroupBox;
        private Label spectralTypeLabel;
        private Label satellitesLabel;
        private Label massLabel;
        private Label diameterLabel;
        private Label nameLabel;
        private CheckBox ringsCheckBox;
        private NumericUpDown massNumericUpDown;
        private NumericUpDown diameterNumericUpDown;
        private TextBox nameTextBox;
        private NumericUpDown satellitesNumericUpDown;
        private TextBox spectralTypeTextBox;
        private Button saveButton;
        private Button cancelButton;
    }
}