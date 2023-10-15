namespace AntiAircraftGun
{
	public partial class FormAntiAirCraftGun : Form
	{
        /// <summary>
        /// Поле-объект для прорисовки объекта
        /// </summary>
        private DrawingAntiAirCraftGun? _drawingAntiAirCraftGun;
		public FormAntiAirCraftGun()
		{
			InitializeComponent();
		}
        /// <summary>
        /// Метод прорисовки машины
        /// </summary>
        private void Draw()
        {
            if (_drawingAntiAirCraftGun == null)
            {
                return;
            }
            Bitmap bmp = new(pictureBoxAntiAircraftGun.Width,pictureBoxAntiAircraftGun.Height);
            Graphics gr = Graphics.FromImage(bmp);
            _drawingAntiAirCraftGun.DrawTransport(gr);
            pictureBoxAntiAircraftGun.Image = bmp;
        }
        private void ButtonMove_Click(object sender, EventArgs e)
        {
            if (_drawingAntiAirCraftGun == null)
            {
                return;
            }
            string name = ((Button)sender)?.Name ?? string.Empty;
            switch (name)
            {
                case "buttonUp":
                    _drawingAntiAirCraftGun.MoveTransport(DirectionType.Up);
                    break;
                case "buttonDown":
                    _drawingAntiAirCraftGun.MoveTransport(DirectionType.Down);
                    break;
                case "buttonLeft":
                    _drawingAntiAirCraftGun.MoveTransport(DirectionType.Left);
                    break;
                case "buttonRight":
                    _drawingAntiAirCraftGun.MoveTransport(DirectionType.Right);
                    break;
            }
            Draw();
        }
        private void buttonCreate_Click(object sender, EventArgs e) 
        {
            Random random = new();
            _drawingAntiAirCraftGun = new DrawingAntiAirCraftGun();
            _drawingAntiAirCraftGun.Init(random.Next(100, 300),//cкорость
            random.Next(1000, 3000), //вес
            Color.FromArgb(random.Next(0, 256), random.Next(0, 256),//основной цвет
            random.Next(0, 256)),
            Color.FromArgb(random.Next(0, 256), random.Next(0, 256),//доп. цвет
            random.Next(0, 256)),

            Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256)), // Доп. цвет2
            Convert.ToBoolean(random.Next(2)), // Rocket
            Convert.ToBoolean(random.Next(2)), // Radar

            pictureBoxAntiAircraftGun.Width, pictureBoxAntiAircraftGun.Height);
            _drawingAntiAirCraftGun.SetPosition(random.Next(10, 100),
            random.Next(10, 100));


            Draw();
        }
        
    }
}