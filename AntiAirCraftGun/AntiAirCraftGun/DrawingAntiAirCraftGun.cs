using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace AntiAircraftGun
{
    public class DrawingAntiAirCraftGun

    {
        private Point[] points = new Point[4];
        /// <summary>
		/// Класс-сущность
		/// </summary>
		public EntityAntiAircraftGun? AntiAircraftGun { get; private set; }
        /// <summary>
        /// Ширина окна
        /// </summary>
        private int _pictureWidth;
        /// <summary>
        /// Высота окна
        /// </summary>
        private int _pictureHeight;
        /// <summary>
        /// Левая координата прорисовки автомобиля
        /// </summary>
        private int _startPosX;
        /// <summary>
        /// Верхняя кооридната прорисовки автомобиля
        /// </summary>
        private int _startPosY;
        /// <summary>
        /// Ширина прорисовки автомобиля
        /// </summary>
        private readonly int _carWidth = 110;
        /// <summary>
        /// Высота прорисовки автомобиля
        /// </summary>
        private readonly int _carHeight = 60;
        /// <summary>
        /// Инициализация свойств
        /// </summary>
        /// <param name="speed">Скорость</param>
        /// <param name="weight">Вес</param>
        /// <param name="bodyColor">Цвет кузова</param>
        
        /// <param name="width">Ширина картинки</param>
        /// <param name="height">Высота картинки</param>
        /// <returns>true - объект создан, false - проверка не пройдена,
        ///нельзя создать объект в этих размерах</returns>
        public bool Init(int speed, double weight, Color bodyColor, Color
        additionalColor, int width, int height)
        {
            // TODO: Продумать проверки
            _pictureWidth = width;
            _pictureHeight = height;
            AntiAircraftGun = new EntityAntiAircraftGun();
            AntiAircraftGun.Init(speed, weight, bodyColor, additionalColor);
            return true;
        }
        /// <summary>
        /// Установка позиции
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        public void SetPosition(int x, int y)
        {
            // TODO: Изменение x, y
            _startPosX = x;
            _startPosY = y;
        }
        /// <summary>
        /// Изменение направления перемещения
        /// </summary>
        /// <param name="direction">Направление</param>
        public void MoveTransport(DirectionType direction)
        {
            if (AntiAircraftGun == null)
            {
                return;
            }
            
            FormAntiAirCraftGun form1 = new FormAntiAirCraftGun();
            Size windowSize = form1.Size;
            int windowWidth = windowSize.Width;
            int windowHeight = windowSize.Height;

            // Теперь вы можете получить ширину и высоту отдельно, если это необходимо

            switch (direction)
            {
                //влево
                case DirectionType.Left:
                    if (_startPosX - AntiAircraftGun.Step > 0)
                    {
                        _startPosX -= (int)AntiAircraftGun.Step;
                    }
                    break;
                //вверх
                case DirectionType.Up:
                    if (_startPosY - AntiAircraftGun.Step > 0)
                    {
                        _startPosY -= (int)AntiAircraftGun.Step;
                    }
                    break;
                // вправо
                case DirectionType.Right:
                    if (_startPosX + AntiAircraftGun.Step < windowWidth-150)
                    {
                        _startPosX += (int)AntiAircraftGun.Step;
                    }
                    break;
                //вниз
                case DirectionType.Down:
                    if (_startPosY + AntiAircraftGun.Step < windowHeight-100)
                    {
                        _startPosY += (int)AntiAircraftGun.Step;
                    }
                    break;
            }
        }
        /// <summary>
        /// Прорисовка объекта
        /// </summary>
        /// <param name="g"></param>
        public void DrawTransport(Graphics g)
        {
            if (AntiAircraftGun == null)
            {
                return;
            }
            Pen pen = new(Color.Black);
            Brush bodyBrush = new SolidBrush(AntiAircraftGun.BodyColor);
            Brush additionalBrush = new SolidBrush(AntiAircraftGun.AdditionalColor);

            // Нарисовать гусеницы
            g.FillEllipse(additionalBrush, _startPosX, _startPosY+40, 110, 10);
            g.DrawEllipse(pen, _startPosX, _startPosY+40, 110, 10);
            g.FillRectangle(bodyBrush, _startPosX, _startPosY+30, 110, 10);
            g.DrawRectangle(pen, _startPosX, _startPosY+30, 110, 10);
            g.FillRectangle(bodyBrush, _startPosX+80, _startPosY+10, 30, 20);
            g.DrawRectangle(pen, _startPosX+80, _startPosY+10, 30, 20);

            points[0] = new Point(_startPosX, _startPosY+30);
            points[1] = new Point(_startPosX+95, _startPosY+5);
            points[2] = new Point(_startPosX+92, _startPosY);
            points[3] = new Point(_startPosX, _startPosY+25);
            g.FillPolygon(additionalBrush, points);
            g.DrawPolygon(pen, points);
            //g.DrawLine(pen, _startPosX, _startPosY+30, _startPosX+95,_startPosY+5 );
            //g.DrawLine(pen, _startPosX+95, _startPosY+5, _startPosX+92, _startPosY);
            //g.DrawLine(pen, _startPosX+92, _startPosY, _startPosX, _startPosY+26);
            //g.DrawLine(pen, _startPosX, _startPosY+26, _startPosX, _startPosY+30);
            for (int i = 0; i < 4; i++)
            {
                Rectangle trackRect = new Rectangle(_startPosX+20 + i*19, _startPosY+40,10, 10);
                g.DrawEllipse(pen, trackRect);
                g.FillEllipse(Brushes.Black, trackRect);
            }
            
            

        }
    }
}

