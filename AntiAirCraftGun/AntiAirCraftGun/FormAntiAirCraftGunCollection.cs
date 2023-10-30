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
        private readonly AntiAirCraftGunGenericStorage _storage;
        public FormAntiAirCraftGunCollection()
        {
            InitializeComponent();
            _storage = new AntiAirCraftGunGenericStorage(pictureBoxCollection.Width,pictureBoxCollection.Height);

        }
        /// <summary>
        /// Заполнение listBoxObjects
        /// </summary>
        private void ReloadObjects()
        {
            int index = listBoxStorages.SelectedIndex;
            listBoxStorages.Items.Clear();
            for (int i = 0; i < _storage.Keys.Count; i++)
            {
                listBoxStorages.Items.Add(_storage.Keys[i]);
            }
            if (listBoxStorages.Items.Count > 0 && (index == -1 || index
            >= listBoxStorages.Items.Count))
            {
                listBoxStorages.SelectedIndex = 0;
            }
            else if (listBoxStorages.Items.Count > 0 && index > -1 &&
            index < listBoxStorages.Items.Count)
            {
                listBoxStorages.SelectedIndex = index;
            }
        }
        /// <summary>
        /// Добавление набора в коллекцию
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddObject_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxStorageName.Text))
            {
                MessageBox.Show("Не все данные заполнены", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _storage.AddSet(textBoxStorageName.Text);
            ReloadObjects();
        }
        /// <summary>
        /// Выбор набора
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBoxObjects_SelectedIndexChanged(object sender,
        EventArgs e)
        {
            pictureBoxCollection.Image =
            _storage[listBoxStorages.SelectedItem?.ToString() ?? string.Empty]?.ShowZenits();
        }
        /// <summary>
        /// Удаление набора
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDelObject_Click(object sender, EventArgs e)
        {
            if (listBoxStorages.SelectedIndex == -1)
            {
                return;
            }
            if (MessageBox.Show($"Удалить объект{ listBoxStorages.SelectedItem}?", "Удаление",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _storage.DelSet(listBoxStorages.SelectedItem.ToString()
                ?? string.Empty);
                ReloadObjects();
            }
        }
        private void ButtonAddZenit_Click(object sender, EventArgs e)
        {
            if (listBoxStorages.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите набор в списке.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var obj = _storage[listBoxStorages.SelectedItem.ToString() ?? string.Empty];
            if (obj == null)
            {
                MessageBox.Show("Выбранный набор не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FormAntiAirCraftGun form = new();
            if (form.ShowDialog() == DialogResult.OK)
            {
                if ((obj + form.SelectedZenit)==1)
                {
                    MessageBox.Show("Объект добавлен");
                    pictureBoxCollection.Image = obj.ShowZenits();
                }
                else
                {
                    MessageBox.Show("Не удалось добавить объект");
                }
            }
        }

        private void ButtonDeleteZenit_Click(object sender, EventArgs e)
        {
            if (listBoxStorages.SelectedIndex == -1)
            {
                return;
            }
            var obj = _storage[listBoxStorages.SelectedItem.ToString() ?? string.Empty];
            if (obj == null)
            {
                return;
            }
            if (MessageBox.Show("Удалить объект?", "Удаление",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            int pos = Convert.ToInt32(maskedTextBoxNumber.Text);
            if (obj - pos != null)
            {
                MessageBox.Show("Объект удален");
                pictureBoxCollection.Image = obj.ShowZenits();
            }
            else
            {
                MessageBox.Show("Не удалось удалить объект");
            }
        }

        private void ButtonUpdateCollection_Click(object sender, EventArgs e)
        {
            if (listBoxStorages.SelectedIndex == -1)
            {
                return;
            }
            var obj = _storage[listBoxStorages.SelectedItem.ToString() ??
            string.Empty];
            if (obj == null)
            {
                return;
            }
            pictureBoxCollection.Image = obj.ShowZenits();

        }
    }
}
