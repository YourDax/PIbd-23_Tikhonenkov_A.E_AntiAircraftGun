using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AntiAircraftGun.Enitites;
using AntiAircraftGun.MovementStrategy;

namespace AntiAircraftGun.DrawingObjects
{
    public class BaseDrawingAntiAirCraftGun
    {
        public EntityAntiAirCraftGun? AntiAirСraftGun { get; protected set; }
        private readonly int _pictureWidth;
        private readonly int _pictureHeight;
        protected int _startPosX;
        protected int _startPosY;
        protected int _zenitWidth = 110;
        protected int _zenitHeight = 60;

        public BaseDrawingAntiAirCraftGun(int speed, double weight, Color bodyColor, Color additionalColor, int width, int height)
        {
            _pictureWidth = width;
            _pictureHeight = height;
            AntiAirСraftGun = new EntityAntiAirCraftGun(speed, weight, bodyColor, additionalColor);
        }

        protected BaseDrawingAntiAirCraftGun(int speed, double weight, Color bodyColor, Color additionalColor, int width, int height, int carWidth, int carHeight)
        {
            _pictureWidth = width;
            _pictureHeight = height;
            _zenitWidth = carWidth;
            _zenitHeight = carHeight;
            AntiAirСraftGun = new EntityAntiAirCraftGun(speed, weight, bodyColor, additionalColor);
        }

        public void SetPosition(int x, int y)
        {
            if (AntiAirСraftGun == null) return;
            _startPosX = x;
            _startPosY = y;
            if (x < 0 || y < 0 || x + _zenitWidth >= _pictureWidth || y + _zenitHeight >= _pictureHeight)
            {
                _startPosX = 1;
                _startPosY = 1;
            }

        }
        /// <summary>
        /// Координата X объекта
        /// </summary>
        public int GetPosX => _startPosX;
        /// <summary>
        /// Координата Y объекта
        /// </summary>
        public int GetPosY => _startPosY;
        /// <summary>
        /// Ширина объекта
        /// </summary>
        public int GetWidth => _zenitWidth;
        /// <summary>
        /// Высота объекта
        /// </summary>
        public int GetHeight => _zenitHeight;

        /// <summary>
        /// Проверка, что объект может переместится по указанному направлению
        /// </summary>
        /// <param name="direction">Направление</param>
        /// <returns>true - можно переместится по указанному направлению</returns>
        public bool CanMove(DirectionType direction)
        {
            if (AntiAirСraftGun == null)
            {
                return false;
            }
            return direction switch
            {
                //влево
                DirectionType.Left => _startPosX - AntiAirСraftGun.Step > 0,
                //вверх
                DirectionType.Up => _startPosY - AntiAirСraftGun.Step > 0,
                // вправо
                DirectionType.Right =>_startPosX + AntiAirСraftGun.Step < _pictureWidth - 110,
                                             //вниз
                DirectionType.Down => _startPosY + AntiAirСraftGun.Step < _pictureHeight - 60,
                _ => false,
            };
        }
        /// <summary>
        /// Изменение направления перемещения
        /// </summary>
        /// <param name="direction">Направление</param>
        public void MoveTransport(DirectionType direction)
        {
            if (!CanMove(direction) || AntiAirСraftGun == null)
            {
                return;
            }
            switch (direction)
            {
                //влево
                case DirectionType.Left:
                    _startPosX -= (int)AntiAirСraftGun.Step;
                    break;
                //вверх
                case DirectionType.Up:
                    _startPosY -= (int)AntiAirСraftGun.Step;
                    break;
                // вправо
                case DirectionType.Right:
                    _startPosX += (int)AntiAirСraftGun.Step;
                    break;
                //вниз
                case DirectionType.Down:
                    _startPosY += (int)AntiAirСraftGun.Step;
                    break;
            }
        }

        public virtual void DrawTransport(Graphics g)
        {
            

            Pen pen = Pens.Black; 
            Brush bodyBrush = new SolidBrush(AntiAirСraftGun.BodyColor);
            Brush additionalBrush = new SolidBrush(AntiAirСraftGun.AdditionalColor);

            g.FillEllipse(additionalBrush, _startPosX, _startPosY + 40, 110, 10);
            g.DrawEllipse(pen, _startPosX, _startPosY + 40, 110, 10);
            g.FillRectangle(bodyBrush, _startPosX, _startPosY + 30, 110, 10);
            g.DrawRectangle(pen, _startPosX, _startPosY + 30, 110, 10);
            g.FillRectangle(bodyBrush, _startPosX + 80, _startPosY + 10, 30, 20);
            g.DrawRectangle(pen, _startPosX + 80, _startPosY + 10, 30, 20);

            for (int i = 0; i < 4; i++)
            {
                Rectangle trackRect = new Rectangle(_startPosX + 20 + i * 19, _startPosY + 40, 10, 10);
                g.DrawEllipse(pen, trackRect);
                g.FillEllipse(Brushes.Black, trackRect);
            }
        }
        /// <summary>
        /// Получение объекта IMoveableObject из объекта DrawningCar
        /// </summary>
        public IMoveableObject GetMoveableObject => new DrawingObjectAntiAirCraftGun(this);

    }
}
