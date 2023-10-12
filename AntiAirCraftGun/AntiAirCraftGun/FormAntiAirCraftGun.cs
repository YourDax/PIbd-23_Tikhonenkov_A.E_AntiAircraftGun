using AntiAircraftGun.DrawingObjects;
using AntiAircraftGun.MovementStrategy;

namespace AntiAircraftGun
{
    public partial class FormAntiAirCraftGun : Form
    {
        private BaseDrawingAntiAirCraftGun _drawing;

        private AbstractStrategy? _abstractStrategy;
        public FormAntiAirCraftGun()
        {
            InitializeComponent();
        }

        private void ButtonMove_Click(object sender, EventArgs e)
        {
            if (_drawing == null)
            {
                return;
            }
            string name = ((Button)sender)?.Name ?? string.Empty;
            switch (name)
            {
                case "buttonUp":
                    _drawing.MoveTransport(DirectionType.Up);
                    break;
                case "buttonDown":
                    _drawing.MoveTransport(DirectionType.Down);
                    break;
                case "buttonLeft":
                    _drawing.MoveTransport(DirectionType.Left);
                    break;
                case "buttonRight":
                    _drawing.MoveTransport(DirectionType.Right);
                    break;
            }
            Draw();
        }
        private void Draw()
        {
            if (_drawing == null)
            {
                return;
            }
            Bitmap bmp = new Bitmap(pictureBoxAntiAircraftGun.Width, pictureBoxAntiAircraftGun.Height);
            Graphics gr = Graphics.FromImage(bmp);
            _drawing.DrawTransport(gr);
            pictureBoxAntiAircraftGun.Image = bmp;
        }

        private void CreateAdvancedAintiAirCraftGun_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            _drawing = new AdvancedDrawingAntAirCraftGun(
                random.Next(100, 300),   // Скорость
                random.Next(1000, 3000), // Вес
                Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256)), // Основной цвет
                Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256)), // Доп. цвет
                Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256)), // Доп. цвет для EntityAdvancedAntiAircraftGun
                Convert.ToBoolean(random.Next(2)), // Rocket
                Convert.ToBoolean(random.Next(2)),
                pictureBoxAntiAircraftGun.Width,
                pictureBoxAntiAircraftGun.Height
            );

            _drawing.SetPosition(random.Next(10, 100), random.Next(10, 100));
            Draw();
        }

        private void CreateAntiAirCraftGun_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            _drawing = new BaseDrawingAntiAirCraftGun(
                random.Next(100, 300),   // Скорость
                random.Next(1000, 3000), // Вес
                Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256)), // Основной цвет
                Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256)), // Доп. цвет
                pictureBoxAntiAircraftGun.Width,
                pictureBoxAntiAircraftGun.Height
            );

            _drawing.SetPosition(random.Next(10, 100), random.Next(10, 100));
            Draw();
        }

        private void ButtonStep_Click(object sender, EventArgs e)
        {
            if (_drawing == null)
            {
                return;
            }
            if (comboBoxStrategy.Enabled)
            {
                _abstractStrategy = comboBoxStrategy.SelectedIndex
                switch
                {
                    0 => new MoveToCenter(),
                    1 => new MoveToBorder(),
                    _ => null,
                };
                if (_abstractStrategy == null)
                {
                    return;
                }
                _abstractStrategy.SetData(new
                DrawingObjectAntiAirCraftGun(_drawing), pictureBoxAntiAircraftGun.Width,
                pictureBoxAntiAircraftGun.Height);
                comboBoxStrategy.Enabled = false;
            }
            if (_abstractStrategy == null)
            {
                return;
            }
            _abstractStrategy.MakeStep();
            Draw();
            if (_abstractStrategy.GetStatus() == Status.Finish)
            {
                comboBoxStrategy.Enabled = true;
                _abstractStrategy = null;
            }

        }

        private void comboBoxStrategy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}