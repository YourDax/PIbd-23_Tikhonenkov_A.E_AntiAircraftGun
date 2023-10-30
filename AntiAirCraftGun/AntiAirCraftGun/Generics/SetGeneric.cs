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
        private readonly T?[] _places;
        /// <summary>
        /// Количество объектов в массиве
        /// </summary>
        public int Count => _places.Length;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="count"></param>
        public SetGeneric(int count)
        {
            _places = new T?[count];
        }
        /// <summary>
        /// Добавление объекта в набор
        /// </summary>
        /// <param name="car">Добавляемый автомобиль</param>
        /// <returns></returns>
        public int Insert(T car)
        {
            // Вставка в начало набора
            for (int i = 0; i < _places.Length; i++)
            {
                if (_places[i] == null)
                {
                    _places[i] = car;
                    return 1;
                }
            }
            return -1; // Если нет пустых мест
        }
        /// <summary>
        /// Добавление объекта в набор на конкретную позицию
        /// /// </summary>
        /// <param name="car">Добавляемый автомобиль</param>
        /// <param name="position">Позиция</param>
        /// <returns></returns>
        public int Insert(T car, int position)
        {
            // Проверка позиции
            if (position < 0 || position >= _places.Length)
                return -1;

            // Проверка, что элемент массива по этой позиции пустой
            if (_places[position] != null)
                return -1;

            // Проверка, что после вставляемого элемента в массиве есть пустой элемент
            for (int i = position + 1; i < _places.Length; i++)
            {
                if (_places[i] == null)
                {
                    // Сдвиг всех объектов справа от позиции до первого пустого элемента
                    for (int j = i; j > position; j--)
                    {
                        _places[j] = _places[j - 1];
                    }
                    _places[position] = car;
                    return 1;
                }
            }

            return -1; // Если нет пустых мест справа
        }
        /// <summary>
        /// Удаление объекта из набора с конкретной позиции
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public bool Remove(int position)
        {
            // Проверка позиции
            if (position < 0 || position >= _places.Length)
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
        public T? Get(int position)
        {
            if (position < 0 || position >= _places.Length)
            {
                // Позиция находится за пределами допустимого диапазона, вернем null
                return null;
            }
            return _places[position];
        }
    }
}
