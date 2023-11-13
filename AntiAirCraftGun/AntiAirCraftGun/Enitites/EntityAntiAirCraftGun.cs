using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntiAircraftGun.Enitites
{
    public class EntityAntiAirCraftGun
    {
        /// <summary>
        /// Скорость
        /// </summary>
        public int Speed { get;  private set; }
        /// <summary>
        /// Вес
        /// </summary>
        public double Weight { get; private set; }
        /// <summary>
        /// Основной цвет
        /// </summary>
        public Color BodyColor { get;  set; }
        /// <summary>
        /// Шаг перемещения автомобиля
        /// </summary>
        public Color AdditionalColor { get;  set; }
        /// <summary>
        /// Шаг перемещения автомобиля
        /// </summary>
        public double Step => (double)Speed * 100 / Weight;
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="speed">Скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="bodyColor">Основной цвет</param>
        public EntityAntiAirCraftGun(int speed, double weight, Color bodyColor, Color additionalColor)
        {
            Speed = speed;
            Weight = weight;
            BodyColor = bodyColor;
            AdditionalColor = additionalColor;
        }
    }
}
