using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntiAircraftGun.MovementStrategy
{
    public class ObjectParameters
    {
        private readonly int _x;
        private readonly int _y;
        private readonly int _width;
        private readonly int _height;
        /// <summary>
        /// Левая граница
        /// </summary>
        public int LeftBorder => _x;
        /// <summary>
        /// Верхняя граница
        /// </summary>
        public int TopBorder => _y;
        /// <summary>
        /// Правая граница
        /// </summary>
        public int RightBorder => _x + _width;
        /// <summary>
        /// Нижняя граница
        /// </summary>
        public int DownBorder => _y + _height;
        /// <summary>
        /// Середина объекта
        /// </summary>
        public int ObjectMiddleHorizontal => _x + _width / 2;
        /// <summary>
        /// Середина объекта
        /// </summary>
        public int ObjectMiddleVertical => _y + _height / 2;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина</param>
        /// <param name="height">Высота</param>
        public ObjectParameters(int x, int y, int width, int height)
        {
            _x = x;
            _y = y;
            _width = width;
            _height = height;
        }
    }
}
