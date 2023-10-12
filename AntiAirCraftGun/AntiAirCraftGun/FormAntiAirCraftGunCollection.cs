using AntiAircraftGun.DrawingObjects;
using AntiAircraftGun.Generics;
using AntiAircraftGun.MovementStrategy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntiAircraftGun
{
    public partial class FormAntiAirCraftGunCollection : Form
    {
        private readonly ZenitsGenericCollection<BaseDrawingAntiAirCraftGun,DrawingObjectAntiAirCraftGun> _zenits;
        public FormAntiAirCraftGunCollection()
        {
            InitializeComponent();
            _zenits = new ZenitsGenericCollection<BaseDrawingAntiAirCraftGun,
                DrawingObjectAntiAirCraftGun>(pictureBoxCollection.Width, pictureBoxCollection.Height);

        }
        private void ButtonAddZenit_Click(object sender, EventArgs e)
        {
            FormAntiAirCraftGun form = new();
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (_zenits + form.SelectedZenit != null)
                {
                    MessageBox.Show("Объект добавлен");
                    pictureBoxCollection.Image = _zenits.ShowZenits();
                }
                else
                {
                    MessageBox.Show("Не удалось добавить объект");
                }

            }
        }

        private void ButtonDeleteZenit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить объект?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)

            {
                return;
            }
            int pos = Convert.ToInt32(textBox.Text);
            if (_zenits - pos != null)
            {
                MessageBox.Show("Объект удален");
                pictureBoxCollection.Image = _zenits.ShowZenits();
            }
            else
            {
                MessageBox.Show("Не удалось удалить объект");
            }
        }

        private void ButtonUpdateCollection_Click(object sender, EventArgs e)
        {
            pictureBoxCollection.Image = _zenits.ShowZenits();

        }
    }
}
