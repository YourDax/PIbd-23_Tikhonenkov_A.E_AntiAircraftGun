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
        private readonly int _zenitWidth = 110;
        /// <summary>
        /// Высота прорисовки автомобиля
        /// </summary>
        private readonly int _zenitHeight = 60;
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
        additionalColor, Color dopColor, bool rocket, bool radar, int width, int height)
        {
            if (width <= _zenitWidth || height <= _zenitHeight) return false;

            _pictureWidth = width;
            _pictureHeight = height;
            AntiAircraftGun = new EntityAntiAircraftGun();
            AntiAircraftGun.Init(speed, weight, bodyColor, additionalColor,dopColor,rocket,radar);
            return true;
        }
        /// <summary>
        /// Установка позиции
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        public void SetPosition(int x, int y)
        {
            if (AntiAircraftGun == null) return;
            _startPosX = x;
            _startPosY = y;
            if (x + _zenitWidth >= _pictureWidth || y + _zenitHeight>= _pictureHeight)
            {
                _startPosX = 1;
                _startPosY = 1;
            }
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
                    if (_startPosX + AntiAircraftGun.Step < _pictureWidth-110)
                    {
                        _startPosX += (int)AntiAircraftGun.Step;
                    }
                    break;
                //вниз
                case DirectionType.Down:
                    if (_startPosY + AntiAircraftGun.Step < _pictureHeight-60)
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

            
            g.FillEllipse(additionalBrush, _startPosX, _startPosY+40, 110, 10);
            g.DrawEllipse(pen, _startPosX, _startPosY+40, 110, 10);
            g.FillRectangle(bodyBrush, _startPosX, _startPosY+30, 110, 10);
            g.DrawRectangle(pen, _startPosX, _startPosY+30, 110, 10);
            g.FillRectangle(bodyBrush, _startPosX+80, _startPosY+10, 30, 20);
            g.DrawRectangle(pen, _startPosX+80, _startPosY+10, 30, 20);
            for (int i = 0; i < 4; i++)
            {
                Rectangle trackRect = new Rectangle(_startPosX+20 + i*19, _startPosY+40, 10, 10);
                g.DrawEllipse(pen, trackRect);
                g.FillEllipse(Brushes.Black, trackRect);
            }
            Brush dopBrush = new SolidBrush(AntiAircraftGun.DopColor);
            Pen dopPen = new Pen(AntiAircraftGun.DopColor);
            if (AntiAircraftGun.Rocket)
            {
                points[0] = new Point(_startPosX, _startPosY + 30);
                points[1] = new Point(_startPosX + 95, _startPosY + 5);
                points[2] = new Point(_startPosX + 92, _startPosY);
                points[3] = new Point(_startPosX, _startPosY + 25);
                g.FillPolygon(dopBrush, points);
                g.DrawPolygon(pen, points);
            }
            if (AntiAircraftGun.Radar)
            {
                g.DrawLine(dopPen, _startPosX + 105, _startPosY + 20, _startPosX +105, _startPosY + 5);
                g.FillPie(dopBrush, _startPosX + 81, _startPosY-15, 30, 30, -45, 180);
                g.DrawLine(dopPen, _startPosX + 98, _startPosY, _startPosX + 93, _startPosY + 10);
                g.FillEllipse(dopBrush, _startPosX + 88, _startPosY -10, 10, 10);
            }
        }
    }
}

