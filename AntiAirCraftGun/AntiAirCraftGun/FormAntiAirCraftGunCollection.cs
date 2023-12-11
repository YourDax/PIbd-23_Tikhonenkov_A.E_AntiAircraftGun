using AntiAircraftGun.DrawingObjects;
using AntiAircraftGun.Exceptions;
using AntiAircraftGun.Generics;
using AntiAircraftGun.MovementStrategy;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Serilog;



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
            Serilog.Log.Information($"Добавлен набор: {textBoxStorageName.Text}");
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
                string name = listBoxStorages.SelectedItem.ToString() ?? string.Empty;
                _storage.DelSet(name);
                ReloadObjects();
                Serilog.Log.Information($"Удален набор: {name}");
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
            FormAntiAirCraftGunConfig form = new();
            form.Show();
            Action<BaseDrawingAntiAirCraftGun>? zenitDelegate = new((m) => {
                
                try
                {
                    bool q = (obj + m);
                    MessageBox.Show("Объект добавлен");
                    Serilog.Log.Information($"Добавлен объект в коллекцию {listBoxStorages.SelectedItem.ToString() ?? string.Empty}");
                    m.ChangePictureBoxSize(pictureBoxCollection.Width, pictureBoxCollection.Height);
                    pictureBoxCollection.Image = obj.ShowZenits();
                }
                catch(StorageOverflowException ex) 
                {
                    Serilog.Log.Warning($"Коллекция {listBoxStorages.SelectedItem.ToString() ?? string.Empty} переполнена");
                    MessageBox.Show(ex.Message);
                }
                catch (ArgumentException ex)
                {
                    Serilog.Log.Warning($"Добавляемый объект уже существует в коллекции {listBoxStorages.SelectedItem.ToString() ?? string.Empty}");
                    MessageBox.Show("Добавляемый объект уже сущесвует в коллекции");
                }
            });
            form.AddEvent(zenitDelegate);
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
            
            try
            {
                int pos = Convert.ToInt32(maskedTextBoxNumber.Text);
                var q = obj - pos;
                MessageBox.Show("Объект удален");
                Serilog.Log.Information($"Удален объект из коллекции {listBoxStorages.SelectedItem.ToString() ?? string.Empty} по номеру {pos}");
                pictureBoxCollection.Image = obj.ShowZenits();
                
            }
            catch(AntiAirCraftGunNotFoundException ex)
            {
                Serilog.Log.Warning($"Не получилось удалить объект из коллекции {listBoxStorages.SelectedItem.ToString() ?? string.Empty}");
                MessageBox.Show(ex.Message);
            }
            catch (FormatException ex)
            {
                Serilog.Log.Warning($"Было введено не число");
                MessageBox.Show("Введите число");
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
        /// <summary>
        /// Обработка нажатия "Сохранение"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _storage.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Serilog.Log.Information($"Файл {saveFileDialog.FileName} успешно сохранен");
                }
                catch(Exception ex)
                {
                    Serilog.Log.Warning($"Не удалось сохранить {saveFileDialog.FileName}");
                    MessageBox.Show($"Не сохранилось: {ex.Message}", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// Обработка нажатия "Загрузка"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _storage.LoadData(openFileDialog.FileName);
                    MessageBox.Show("Загрузка прошла успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Serilog.Log.Information($"Файл {openFileDialog.FileName} успешно загружен");
                    foreach (var collection in _storage.Keys)
                    {
                        listBoxStorages.Items.Add(collection);
                    }
                }
                catch (Exception ex)
                {
                    Serilog.Log.Warning("Не удалось загрузить");
                    MessageBox.Show($"Не загрузилось: {ex.Message}", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
            }
        }

    }
}
