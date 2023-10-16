using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntiAircraftGun.Generics
{
    internal class SetGeneric<T>
        where T : class
    {
        /// <summary>
        /// Массив объектов, которые храним
        /// </summary>
        private readonly List<T?> _places;
        /// <summary>
        /// Количество объектов в списке
        /// </summary>
        public int Count => _places.Count;
        /// <summary>
        /// Максимальное количество объектов в списке
        /// </summary>
        private readonly int _maxCount;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="count"></param>
        public SetGeneric(int count)
        {
            _maxCount = count;
            _places = new List<T?>(count);
        }
        /// <summary>
        /// Добавление объекта в набор
        /// </summary>
        /// <param name="car">Добавляемый автомобиль</param>
        /// <returns></returns>
        public bool Insert(T car)
        {
            if (_places.Count == _maxCount)
                return false;
            Insert(car, 0);
            return true;

        }

        public bool Insert(T car, int position)
        {
            if (!(position >= 0 && position <= Count && _places.Count < _maxCount))
                return false;
            _places.Insert(position, car);
            return true;
        }

        /// <summary>
        /// Удаление объекта из набора с конкретной позиции
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public bool Remove(int position)
        {
            // Проверка позиции
            if (position < 0 || position >= Count)
                return false;

            // Удаление объекта из массива, присвоив элементу массива значение null
            _places[position] = null;
            return true;
        }
        /// <summary>
        /// Получение объекта из набора по позиции
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public T? this[int position]
        {
            get
            {
                // TODO: Проверить позицию
                if (position < 0 || position >= Count)
                {
                    MessageBox.Show("Индекс выходит за пределы диапазона");
                }
                return _places[position];
            }
            set
            {
                // TODO: Проверить позицию
                if (position < 0 || position >= Count)
                {
                    throw new IndexOutOfRangeException("Индекс выходит за пределы диапазона");
                }
                // TODO: Проверить наличие доступных слотов в списке
                if (_places.Count < _maxCount)
                {
                    // Вставить на указанную позицию
                    _places.Insert(position, value);
                }
                else
                {
                    throw new InvalidOperationException("Список уже заполнен");
                }
            }
        }
        /// <summary>
        /// Проход по списку
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T?> GetZenits(int? maxCars = null)
        {
            for (int i = 0; i < _places.Count; ++i)
            {
                yield return _places[i];
                if (maxCars.HasValue && i == maxCars.Value)
                {
                    yield break;
                }
            }
        }
        public T? Get(int position)
        {
            if (position < 0 || position >= Count)
            {
                // Позиция находится за пределами допустимого диапазона, вернем null
                return null;
            }
            return _places[position];
        }
    }
}
