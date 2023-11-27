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
        /// Разделитель для записи ключа и значения элемента словаря
        /// </summary>
        private static readonly char _separatorForKeyValue = '|';
        /// <summary>
        /// Разделитель для записей коллекции данных в файл
        /// </summary>
        private readonly char _separatorRecords = ';';
        /// <summary>
        /// Разделитель для записи информации по объекту в файл
        /// </summary>
        private static readonly char _separatorForObject = ':';
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
        /// <summary>
        /// Сохранение информации по автомобилям в хранилище в файл
        /// </summary>
        /// <param name="filename">Путь и имя файла</param>
        /// <returns>true - сохранение прошло успешно, false - ошибка при сохранении данных</returns>
        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            StringBuilder data = new();
            foreach (KeyValuePair<string,
            AntiAirCraftGunGenericCollection<BaseDrawingAntiAirCraftGun, DrawingObjectAntiAirCraftGun>> record in _zenitStorages)
            {
                StringBuilder records = new();
                foreach (BaseDrawingAntiAirCraftGun? elem in record.Value.GetCars)
                {
                    records.Append($"{elem?.GetDataForSave(_separatorForObject)}{_separatorRecords}");
                }
                data.AppendLine($"{record.Key}{_separatorForKeyValue}{records}");
            }
            if (data.Length == 0)
            {
                return false;
            }
            using FileStream fs = new(filename, FileMode.Create);
            byte[] info = new
            UTF8Encoding(true).GetBytes($"CarStorage{Environment.NewLine}{data}");
            fs.Write(info, 0, info.Length);
            return true;
        }
        /// <summary>
        /// Загрузка информации по автомобилям в хранилище из файла
        /// </summary>
        /// <param name="filename">Путь и имя файла</param>
        /// <returns>true - загрузка прошла успешно, false - ошибка при загрузке данных</returns>
        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }
            using (StreamReader sr = new(filename))
            {
                string str = sr.ReadLine();
                var strs = str.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                if (strs == null || strs.Length == 0)
                {
                    return false;
                }
                if (!strs[0].StartsWith("CarStorage"))
                {
                    return false;
                }
                _zenitStorages.Clear();
                do
                {
                    string[] record = str.Split(_separatorForKeyValue, StringSplitOptions.RemoveEmptyEntries);
                    if (record.Length != 2)
                    {
                        str = sr.ReadLine();
                        continue;
                    }
                    AntiAirCraftGunGenericCollection<BaseDrawingAntiAirCraftGun, DrawingObjectAntiAirCraftGun> collection = new(_pictureWidth, _pictureHeight);
                    string[] set = record[1].Split(_separatorRecords, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string elem in set)
                    {
                        BaseDrawingAntiAirCraftGun? zenit =
                        elem?.CreateDrawningAntiAirCraftGun(_separatorForObject, _pictureWidth, _pictureHeight);
                        if (zenit != null)
                        {
                            if (!(collection + zenit))
                            {
                                return false;
                            }
                        }
                    }
                    _zenitStorages.Add(record[0], collection);

                    str = sr.ReadLine();
                } while (str != null);
            }
            return true;
        }
    }
}
    