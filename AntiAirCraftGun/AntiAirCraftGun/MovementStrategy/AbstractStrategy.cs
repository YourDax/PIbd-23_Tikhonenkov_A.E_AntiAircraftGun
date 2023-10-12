using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AntiAircraftGun.MovementStrategy
{
    public abstract class AbstractStrategy
    {
        /// <summary>
        /// Перемещаемый объект
        /// </summary>
        private IMoveableObject? _moveableObject;
        /// <summary>
        /// Статус перемещения
        /// </summary>
        private Status _state = Status.NotInit;
        /// <summary>
        /// Ширина поля
        /// </summary>
        protected int FieldWidth { get; private set; }
        /// <summary>
        /// Высота поля
        /// </summary>
        protected int FieldHeight { get; private set; }
        /// <summary>
        /// Статус перемещения
        /// </summary>
        public Status GetStatus() { return _state; }
        /// <summary>
        /// Установка данных
        /// </summary>
        /// <param name="moveableObject">Перемещаемый объект</param>
        /// <param name="width">Ширина поля</param>
        /// <param name="height">Высота поля</param>
        public void SetData(IMoveableObject moveableObject, int width, int
        height)
        {
            if (moveableObject == null)
            {
                _state = Status.NotInit;
                return;
            }
            _state = Status.InProgress;
            _moveableObject = moveableObject;
            FieldWidth = width;
            FieldHeight = height;
        }
        /// <summary>
        /// Шаг перемещения
        /// </summary>
        public void MakeStep()
        {
            if (_state != Status.InProgress)
            {
                return;
            }
            if (IsTargetDestinaion())
            {
                _state = Status.Finish;
                return;
            }
            MoveToTarget();
        }
        /// <summary>
        /// Перемещение влево
        /// </summary>
        /// <returns>Результат перемещения (true - удалось переместиться, false - неудача)</returns>
        protected bool MoveLeft() => MoveTo(DirectionType.Left);
        /// <summary>
        /// Перемещение вправо
        /// </summary>
        /// <returns>Результат перемещения (true - удалось переместиться,false - неудача)</returns>
        protected bool MoveRight() => MoveTo(DirectionType.Right);
        /// <summary>
        /// Перемещение вверх
        /// </summary>
        /// <returns>Результат перемещения (true - удалось переместиться, false - неудача)</returns>
        protected bool MoveUp() => MoveTo(DirectionType.Up);
        /// <summary>
        /// Перемещение вниз
        /// </summary>
        /// <returns>Результат перемещения (true - удалось переместиться, false - неудача)</returns>
        protected bool MoveDown() => MoveTo(DirectionType.Down);
        /// <summary>
        /// Параметры объекта
        /// </summary>
        protected ObjectParameters? GetObjectParameters =>
        _moveableObject?.GetObjectPosition;
        /// <summary>
        /// Шаг объекта
        /// </summary>
        /// <returns></returns>
        protected int? GetStep()
        {
            if (_state != Status.InProgress)
            {
                return null;
            }
            return _moveableObject?.GetStep;
        }
        /// <summary>
        /// Перемещение к цели
        /// </summary>
        protected abstract void MoveToTarget();
        /// <summary>
        /// Достигнута ли цель
        /// </summary>
        /// <returns></returns>
        protected abstract bool IsTargetDestinaion();
        /// <summary>
        /// Попытка перемещения в требуемом направлении
        /// </summary>
        /// <param name="directionType">Направление</param>
        /// <returns>Результат попытки (true - удалось переместиться, false - неудача)</returns>
    private bool MoveTo(DirectionType directionType)
        {
            if (_state != Status.InProgress)
            {
                return false;
            }
            if (_moveableObject?.CheckCanMove(directionType) ?? false)
            {
                _moveableObject.MoveObject(directionType);
                return true;
            }
            return false;
        }
        }
}
