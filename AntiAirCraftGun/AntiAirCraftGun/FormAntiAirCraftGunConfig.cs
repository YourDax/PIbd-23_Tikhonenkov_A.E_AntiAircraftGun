using AntiAircraftGun.DrawingObjects;
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
    public partial class FormAntiAirCraftGunConfig : Form
    {
        /// <summary>
        /// Делегат для передачи объекта-автомобиля
        /// </summary>
       
        public delegate void CarDelegate(BaseDrawingAntiAirCraftGun zenit);
        /// <summary>
        /// Переменная-выбранная машина
        /// </summary>
        BaseDrawingAntiAirCraftGun? _zenit = null;
        /// <summary>
        /// Событие
        /// </summary>
        private event CarDelegate? EventAddZenit;

        /// <summary>
        /// Конструктор
        /// </summary>
        public FormAntiAirCraftGunConfig()
        {
            InitializeComponent();
            panelBlack.MouseDown += PanelColor_MouseDown;
            panelGreen.MouseDown += PanelColor_MouseDown;
            panelRed.MouseDown += PanelColor_MouseDown;
            panelBlue.MouseDown += PanelColor_MouseDown;
            panelGreen.MouseDown += PanelColor_MouseDown;
            panelYellow.MouseDown += PanelColor_MouseDown;
            panelPurple.MouseDown += PanelColor_MouseDown;
            panelWhite.MouseDown += PanelColor_MouseDown;
            
            buttonCancel.Click += (s, e) => Close();
        }

        public void DrawAntiAirCraftGun()
        {
            Bitmap bmp = new Bitmap(pictureBoxObject.Width, pictureBoxObject.Height);
            Graphics gr = Graphics.FromImage(bmp);
            _zenit?.SetPosition(5, 5);
            _zenit?.DrawTransport(gr);
            pictureBoxObject.Image = bmp;
        }
        public void AddEvent(CarDelegate ev)
        {
            if (EventAddZenit == null)
            {
                EventAddZenit = ev;
            }
            else
            {
                EventAddZenit += ev;
            }
        }

        private void PanelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Panel)?.DoDragDrop((sender as Panel)?.BackColor,DragDropEffects.Move | DragDropEffects.Copy);

        }

        private void allowPanel_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data?.GetData(DataFormats.Text).ToString())
            {
                case "labelBase":
                    _zenit = new BaseDrawingAntiAirCraftGun((int)numericUpDownSpeed.Value,
                   (int)numericUpDownWeight.Value, Color.White, Color.Black, pictureBoxObject.Width,
                   pictureBoxObject.Height);
                    break;
                case "labelAdvanced":
                    _zenit = new AdvancedDrawingAntiAirCraftGun((int)numericUpDownSpeed.Value,
                   (int)numericUpDownWeight.Value, Color.White, Color.Black ,Color.Silver, checkBoxRadar.Checked,
                   checkBoxRocket.Checked, pictureBoxObject.Width,pictureBoxObject.Height);
                    break;
            }
            labelColor.BackColor = Color.Empty;
            labelAdditionalColor.BackColor = Color.Empty;
            DrawAntiAirCraftGun();

        }

        private void allowPanel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data?.GetDataPresent(DataFormats.Text) ?? false)
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            EventAddZenit?.Invoke(_zenit);
            Close();
        }

        private void LabelObject_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Label)?.DoDragDrop((sender as Label)?.Name, DragDropEffects.Move | DragDropEffects.Copy);
        }


        private void colorLabel_DragDrop(object sender, DragEventArgs e)
        {
            if (_zenit == null)
                return;
            labelColor.BackColor = (Color)e.Data.GetData(typeof(Color));
            _zenit.ChangeColor(labelColor.BackColor);
            DrawAntiAirCraftGun();
        }

        private void colorLabel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void addColorLabel_DragDrop(object sender, DragEventArgs e)
        {
            if ((_zenit == null) || (_zenit is AdvancedDrawingAntiAirCraftGun == false))
                return;
            labelAdditionalColor.BackColor = (Color)e.Data.GetData(typeof(Color));
            ((AdvancedDrawingAntiAirCraftGun)_zenit).ChangeAddColor(labelAdditionalColor.BackColor);
            DrawAntiAirCraftGun();
        }

        
    }
}

