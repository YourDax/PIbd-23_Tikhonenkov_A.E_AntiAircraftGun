using AntiAircraftGun.DrawingObjects;
using AntiAircraftGun.MovementStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntiAircraftGun.Generics
{
    /// <summary>
    /// Класс для хранения коллекции
    /// </summary>
    internal class AntiAirCraftGunGenericStorage
    {
        /// <summary>
        /// Словарь (хранилище)
        /// </summary>
        readonly Dictionary<string, AntiAirCraftGunGenericCollection<BaseDrawingAntiAirCraftGun, DrawingObjectAntiAirCraftGun>> _zenitStorages;
        /// <summary>
        /// Возвращение списка названий наборов
        /// </summary>
        public List<string> Keys => _zenitStorages.Keys.ToList();
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private readonly int _pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private readonly int _pictureHeight;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="pictureWidth"></param>
        /// <param name="pictureHeight"></param>
        public AntiAirCraftGunGenericStorage(int pictureWidth, int pictureHeight)
        {
            _zenitStorages = new Dictionary<string, AntiAirCraftGunGenericCollection<BaseDrawingAntiAirCraftGun, DrawingObjectAntiAirCraftGun>>();
            _pictureWidth = pictureWidth;
            _pictureHeight = pictureHeight;
        }
        /// <summary>
        /// Добавление набора
        /// </summary>
        /// <param name="name">Название набора</param>
        public void AddSet(string name)
        {
            // TODO: Прописать логику для добавления набора
            if (_zenitStorages.ContainsKey(name))
            {
                MessageBox.Show("Набор с таким именем уже существует");
                return;
            }
            
            _zenitStorages.Add(name, new AntiAirCraftGunGenericCollection<BaseDrawingAntiAirCraftGun, DrawingObjectAntiAirCraftGun>(_pictureWidth, _pictureHeight));
        }

        /// <summary>
        /// Удаление набора
        /// </summary>
        /// <param name="name">Название набора</param>
        public void DelSet(string name)
        {
            // TODO: Прописать логику для удаления набора
            if (_zenitStorages.ContainsKey(name) == null)
            {
                return;
            }

            _zenitStorages.Remove(name);
        }
        /// <summary>
        /// Доступ к набору
        /// </summary>
        /// <param name="ind"></param>
        /// <returns></returns>
        public AntiAirCraftGunGenericCollection<BaseDrawingAntiAirCraftGun, DrawingObjectAntiAirCraftGun>?
        this[string ind]
        {
            get
            {
                // TODO: Продумать логику получения набора
                if (_zenitStorages.ContainsKey(ind))
                {
                    return _zenitStorages[ind];
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
