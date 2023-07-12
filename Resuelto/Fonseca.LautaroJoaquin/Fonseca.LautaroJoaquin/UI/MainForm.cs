using Entities.Entities;
using Entities.Repositories;
using UI.Components;

namespace UI
{
    public partial class MainForm : Form
    {
        private Planetary planetary;

        public MainForm()
        {
            InitializeComponent();

            planetary = new Planetary();

            this.listBox.Items.AddRange(this.planetary.GetElements().ToArray());
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AstralBodyForm form = new();

            if (form.ShowDialog() == DialogResult.OK && form.AstralBody is not null)
            {
                this.planetary.Save(form.AstralBody);
            }
            this.listBox.Items.Clear();
            this.listBox.Items.AddRange(this.planetary.GetElements().ToArray());
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem is AstralBody astral)
            {
                this.listBox.Items.Clear();
                this.planetary.Delete(astral);
                this.listBox.Items.AddRange(this.planetary.GetElements().ToArray());
            }
            else
            {
                MessageBox.Show("Debe Seleccionar un Astro primero!");
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem is AstralBody astral)
            {
                AstralBodyForm form = new(astral);

                if (form.ShowDialog() == DialogResult.OK && form.AstralBody is not null)
                {
                    this.listBox.Items.Clear();
                    this.listBox.Items.AddRange(this.planetary.GetElements().ToArray());
                }
            }
            else
            {
                MessageBox.Show("Debe Seleccionar un Astro primero!");
            }
        }
    }
}