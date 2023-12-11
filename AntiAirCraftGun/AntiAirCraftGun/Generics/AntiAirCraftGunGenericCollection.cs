using AntiAircraftGun.DrawingObjects;
using AntiAircraftGun.MovementStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntiAircraftGun.Generics
{
    internal class AntiAirCraftGunGenericCollection<T,U>
        where T : BaseDrawingAntiAirCraftGun
        where U : IMoveableObject
    {
        /// <summary>
        /// Получение объектов коллекции
        /// </summary>
        public IEnumerable<T?> GetCars => _collection.GetZenits();
        /// <summary>
        /// Ширина окна прорисовки
        /// </summary>
        private readonly int _pictureWidth;
        /// <summary>
        /// Высота окна прорисовки
        /// </summary>
        private readonly int _pictureHeight;
        /// <summary>
        /// Размер занимаемого объектом места (ширина)
        /// </summary>
        private readonly int _placeSizeWidth = 210;
        /// <summary>
        /// Размер занимаемого объектом места (высота)
        /// </summary>
        private readonly int _placeSizeHeight = 90;
        /// <summary>
        /// Набор объектов
        /// </summary>
        private readonly SetGeneric<T> _collection;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="picWidth"></param>
        /// <param name="picHeight"></param>
        public AntiAirCraftGunGenericCollection(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _pictureWidth = picWidth;
            _pictureHeight = picHeight;
            _collection = new SetGeneric<T>(width * height);
        }
        /// <summary>
        /// Перегрузка оператора сложения
        /// </summary>
        /// <param name="collect"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static bool operator +(AntiAirCraftGunGenericCollection<T,U> collect, T? obj)
        {
            if (obj == null)
                return false;
            return collect?._collection.Insert(obj) ?? false;
        }
        /// <summary>
        /// Перегрузка оператора вычитания
        /// </summary>
        /// <param name="collect"></param>
        /// <param name="pos"></param>
        /// <returns></returns>
        public static T? operator -(AntiAirCraftGunGenericCollection<T, U> collect, int pos)
        {
            T? obj = collect._collection.Get(pos);
            collect._collection.Remove(pos);
            return obj;
        }
        
        /// <summary>
        /// Получение объекта IMoveableObject
        /// </summary>
        /// <param name="pos"></param>
        /// <returns></returns>
        public U? GetU(int pos)
        {
            return (U?)_collection[pos]?.GetMoveableObject;
        }
        /// <summary>
        /// Вывод всего набора объектов
        /// </summary>
        /// <returns></returns>
        public Bitmap ShowZenits()
        {
            Bitmap bmp = new(_pictureWidth, _pictureHeight);
            Graphics gr = Graphics.FromImage(bmp);
            DrawBackground(gr);
            DrawObjects(gr);
            return bmp;
        }
        /// <summary>
        /// Метод отрисовки фона
        /// </summary>
        /// <param name="g"></param>
        private void DrawBackground(Graphics g)
        {
            Pen pen = new(Color.Black, 3);
            for (int i = 0; i < _pictureWidth / _placeSizeWidth; i++)
            {
                for (int j = 0; j < _pictureHeight / _placeSizeHeight +
                1; ++j)
                {//линия разметки места
                    g.DrawLine(pen, i * _placeSizeWidth, j *
                    _placeSizeHeight, i * _placeSizeWidth + _placeSizeWidth / 2, j *
                    _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i *
                _placeSizeWidth, _pictureHeight / _placeSizeHeight * _placeSizeHeight);
            }
        }
        /// <summary>
        /// Метод прорисовки объектов
        /// </summary>
        /// <param name="g"></param>
        private void DrawObjects(Graphics g)
        {
            int x = 0; // Начальная координата X
            int y = 0; // Начальная координата Y
            int maxX = _pictureWidth; // Максимальное значение X, при достижении которого будет ошибка
            int maxY = _pictureHeight; // Максимальное значение Y, когда нужно изменить X
            int distance_between_objects = _placeSizeHeight;

            foreach (var zenit in _collection.GetZenits())
            {
                
                T? obj = zenit;

                if (obj != null)
                {
                    // Проверяем, если X достигло максимума, выводим ошибку
                    if (x >= maxX)
                    {
                        MessageBox.Show("Не хватает места для объекта.");
                        break;
                    }

                    // Устанавливаем позицию 
                    obj.SetPosition(x, y + 10);

                    // TODO: Прорисовка объекта
                    obj.DrawTransport(g);

                    // Увеличиваем координату Y для следующего объекта
                    y += distance_between_objects;

                    // Проверяем, если Y достигло максимума, изменяем X и сбрасываем Y
                    if (y + distance_between_objects >= maxY)
                    {
                        y = 0;
                        x += _placeSizeWidth;
                    }
                }
                if (obj == null) 
                {
                    // Увеличиваем координату Y для следующего объекта
                    y += distance_between_objects;

                    // Проверяем, если Y достигло максимума, изменяем X и сбрасываем Y
                    if (y+distance_between_objects >= maxY)
                    {
                        y = 0;
                        x += _placeSizeWidth;
                    }
                };
            }
        }
    }
}
