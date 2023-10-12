using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntiAircraftGun
{
    public class EntityAntiAircraftGun
    {
        /// <summary>
		/// Скорость
		/// </summary>
		public int Speed { get; private set; }
        /// <summary>
        /// Вес
        /// </summary>
        public double Weight { get; private set; }
        /// <summary>
        /// Основной цвет
        /// </summary>
        public Color BodyColor { get; private set; }
        /// <summary>
        /// Дополнительный цвет (для опциональных элементов)
        /// </summary>
        public Color AdditionalColor { get; private set; }
        /// <summary>
        /// Шаг перемещения автомобиля
        /// </summary>
        public double Step => (double)Speed * 100 / Weight;
        /// <summary>
        /// Цвет для доп. деталей
        /// </summary>
        public Color DopColor { get; private set; }
        /// <summary>
        /// Ракета
        /// </summary>
        public bool Rocket { get; private set; }
        /// <summary>
        /// Радар
        /// </summary>
        public bool Radar { get; private set; }
        /// <summary>
        /// Инициализация полей объекта-класса спортивного автомобиля
        /// </summary>
        /// <param name="speed">Скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="bodyColor">Основной цвет</param>

        public void Init(int speed, double weight, Color bodyColor, Color additionalColor, Color dopColor, bool rocket, bool radar)
        {
            Speed = speed;
            Weight = weight;
            BodyColor = bodyColor;
            AdditionalColor = additionalColor;
            DopColor = dopColor;
            Rocket = rocket;
            Radar = radar;
        }
    }
}
