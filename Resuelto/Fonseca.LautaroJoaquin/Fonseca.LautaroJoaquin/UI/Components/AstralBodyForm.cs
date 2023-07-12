using Entities.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Components
{
    public partial class AstralBodyForm : Form
    {
        public AstralBody? AstralBody { get; private set; }

        public AstralBodyForm(AstralBody? astralBody)
        {
            InitializeComponent();

            this.AstralBody = astralBody;

            if (astralBody is not null)
            {
                planetRadioButton.Enabled = false;
                starRadioButton.Enabled = false;


                if (astralBody is Star)
                {
                    starRadioButton.Checked = true;
                }
                else
                {
                    planetRadioButton.Checked = true;
                }

                nameTextBox.Text = astralBody.Name;
                massNumericUpDown.Value = (decimal) astralBody.Mass;
                diameterNumericUpDown.Value = (decimal) astralBody.Diameter;

            }
        }

        public AstralBodyForm(): this(null)
        {
        }

        private void planetRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ToggleFields(planetRadioButton.Checked);
        }

        private void ToggleFields(bool isPlanet)
        {
            ringsCheckBox.Visible = isPlanet;
            satellitesLabel.Visible = isPlanet;
            satellitesNumericUpDown.Visible = isPlanet;

            spectralTypeLabel.Visible = !isPlanet;
            spectralTypeTextBox.Visible = !isPlanet;
        }

        private void starRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ToggleFields(!starRadioButton.Checked);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Count(it => char.IsLetter(it)) == 0)
            {
                MessageBox.Show("El Nombre del Astro no puede estar vacio!");
                return;
            }

            if (!planetRadioButton.Checked && spectralTypeTextBox.Text.Count(it => char.IsLetter(it)) == 0)
            {
                MessageBox.Show("El Tipo Espectral no puede estar vacio!");
                return;
            }

            if (planetRadioButton.Checked)
            {
                if (AstralBody is Planet planet)
                {
                    planet.Name = nameTextBox.Text;
                    planet.Diameter = (double)diameterNumericUpDown.Value;
                    planet.Mass = (double)massNumericUpDown.Value;
                    planet.HasRings = ringsCheckBox.Checked;
                    planet.Satellites = (int)satellitesNumericUpDown.Value;
                }
                else
                {
                    AstralBody = new Planet(
                        0,
                        nameTextBox.Text,
                        (double)diameterNumericUpDown.Value,
                        (double)massNumericUpDown.Value,
                        ringsCheckBox.Checked,
                        (int)satellitesNumericUpDown.Value
                    );
                }
            }
            else
            {
                if (AstralBody is Star star)
                {
                    star.Name = nameTextBox.Text;
                    star.Diameter = (double)diameterNumericUpDown.Value;
                    star.Mass = (double)massNumericUpDown.Value;
                    star.SpectralType = spectralTypeTextBox.Text;
                }
                else
                {
                    AstralBody = new Star(
                        0,
                        nameTextBox.Text,
                        (double)diameterNumericUpDown.Value,
                        (double)massNumericUpDown.Value,
                        spectralTypeTextBox.Text
                    );
                }
            }

            this.DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
