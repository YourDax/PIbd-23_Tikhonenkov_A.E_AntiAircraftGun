using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AntiAircraftGun.Enitites;

namespace AntiAircraftGun.DrawingObjects
{
    public class BaseDrawingAntiAirCraftGun
    {
        public EntityAntiAirCraftGun? EntityAntiAirСraftGun { get; protected set; }
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
            EntityAntiAirСraftGun = new EntityAntiAirCraftGun(speed, weight, bodyColor, additionalColor);
        }

        protected BaseDrawingAntiAirCraftGun(int speed, double weight, Color bodyColor, Color additionalColor, int width, int height, int carWidth, int carHeight)
        {
            _pictureWidth = width;
            _pictureHeight = height;
            _zenitWidth = carWidth;
            _zenitHeight = carHeight;
            EntityAntiAirСraftGun = new EntityAntiAirCraftGun(speed, weight, bodyColor, additionalColor);
        }

        public void SetPosition(int x, int y)
        {
            if (x < 0 || y < 0)
            {
                _startPosX = 10;
                _startPosY = 10;
            }
            else
            {
                _startPosX = x;
                _startPosY = y;
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
            if (EntityAntiAirСraftGun == null)
            {
                return false;
            }
            return direction switch
            {
                //влево
                DirectionType.Left => _startPosX - EntityAntiAirСraftGun.Step > 0,
                //вверх
                DirectionType.Up => _startPosY - EntityAntiAirСraftGun.Step > 0,
                // вправо
                DirectionType.Right =>_startPosX + EntityAntiAirСraftGun.Step < _pictureWidth - 110,
                                             //вниз
                DirectionType.Down => _startPosY + EntityAntiAirСraftGun.Step < _pictureHeight - 60,
                _ => false,
            };
        }
        /// <summary>
        /// Изменение направления перемещения
        /// </summary>
        /// <param name="direction">Направление</param>
        public void MoveTransport(DirectionType direction)
        {
            if (!CanMove(direction) || EntityAntiAirСraftGun == null)
            {
                return;
            }
            switch (direction)
            {
                //влево
                case DirectionType.Left:
                    _startPosX -= (int)EntityAntiAirСraftGun.Step;
                    break;
                //вверх
                case DirectionType.Up:
                    _startPosY -= (int)EntityAntiAirСraftGun.Step;
                    break;
                // вправо
                case DirectionType.Right:
                    _startPosX += (int)EntityAntiAirСraftGun.Step;
                    break;
                //вниз
                case DirectionType.Down:
                    _startPosY += (int)EntityAntiAirСraftGun.Step;
                    break;
            }
        }

        public virtual void DrawTransport(Graphics g)
        {
            

            Pen pen = Pens.Black; 
            Brush bodyBrush = new SolidBrush(EntityAntiAirСraftGun.BodyColor);
            Brush additionalBrush = new SolidBrush(EntityAntiAirСraftGun.AdditionalColor);

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
    }
}
