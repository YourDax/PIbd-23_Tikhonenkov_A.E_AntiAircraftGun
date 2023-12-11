using AntiAircraftGun.DrawingObjects;
using AntiAircraftGun.MovementStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
        readonly Dictionary<AntiAirCraftGunCollectionInfo, AntiAirCraftGunGenericCollection<BaseDrawingAntiAirCraftGun, DrawingObjectAntiAirCraftGun>> _zenitStorages;
        /// <summary>
        /// Возвращение списка названий наборов
        /// </summary>
        public List<AntiAirCraftGunCollectionInfo> Keys => _zenitStorages.Keys.ToList();
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
            _zenitStorages = new Dictionary<AntiAirCraftGunCollectionInfo, AntiAirCraftGunGenericCollection<BaseDrawingAntiAirCraftGun, DrawingObjectAntiAirCraftGun>>();
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
            if (_zenitStorages.ContainsKey(new AntiAirCraftGunCollectionInfo(name, string.Empty)))
            {
                MessageBox.Show("Набор с таким именем уже существует");
                return;
            }
            
            _zenitStorages.Add(new AntiAirCraftGunCollectionInfo(name,string.Empty), new AntiAirCraftGunGenericCollection<BaseDrawingAntiAirCraftGun, DrawingObjectAntiAirCraftGun>(_pictureWidth, _pictureHeight));
        }

        /// <summary>
        /// Удаление набора
        /// </summary>
        /// <param name="name">Название набора</param>
        public void DelSet(string name)
        {
            // TODO: Прописать логику для удаления набора
            if (!_zenitStorages.ContainsKey(new AntiAirCraftGunCollectionInfo(name, string.Empty)))
            {
                return;
            }

            _zenitStorages.Remove(new AntiAirCraftGunCollectionInfo(name, string.Empty));
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
                AntiAirCraftGunCollectionInfo indobj = new AntiAirCraftGunCollectionInfo(ind, string.Empty);
                // TODO: Продумать логику получения набора
                if (_zenitStorages.ContainsKey(indobj))
                {
                    return _zenitStorages[indobj];
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
            foreach (KeyValuePair<AntiAirCraftGunCollectionInfo, AntiAirCraftGunGenericCollection<BaseDrawingAntiAirCraftGun, DrawingObjectAntiAirCraftGun>> record in _zenitStorages)
            {
                StringBuilder records = new();
                foreach (BaseDrawingAntiAirCraftGun? elem in record.Value.GetCars)
                {
                    records.Append($"{elem?.GetDataForSave(_separatorForObject)}{_separatorRecords}");
                }
                data.AppendLine($"{record.Key.Name}{_separatorForKeyValue}{records}");
            }
            if (data.Length == 0)
            {
                throw new Exception("Невалидная операция, нет данных для сохранения");
            }
            string toWrite = $"CarStorage{Environment.NewLine}{data}";
            var strs = toWrite.Split(new char[] { '\n', '\r' },  StringSplitOptions.RemoveEmptyEntries);
            using (StreamWriter sw = new(filename))
            {
                foreach (var str in strs)
                {
                    sw.WriteLine(str);
                }
            }
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
                throw new IOException("Файл не найден");
            }
            using (StreamReader sr = new(filename))
            {
                string str = sr.ReadLine();
                var strs = str.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                if (strs == null || strs.Length == 0)
                {
                    throw new IOException("Нет данных для загрузки");
                }
                if (!strs[0].StartsWith("CarStorage"))
                {
                    throw new IOException("Неверный формат данных");
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
                                throw new Exception("Ошибка добавления в коллекцию");
                            }
                        }
                    }
                    _zenitStorages.Add(new AntiAirCraftGunCollectionInfo(record[0],string.Empty), collection);

                    str = sr.ReadLine();
                } while (str != null);
            }
            return true;
        }       
    }
}
    