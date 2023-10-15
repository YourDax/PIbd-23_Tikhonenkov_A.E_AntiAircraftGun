using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AntiAircraftGun.DrawingObjects;

namespace AntiAircraftGun.MovementStrategy
{
    public class DrawingObjectAntiAirCraftGun : IMoveableObject
    {
        private readonly BaseDrawingAntiAirCraftGun? _drawningCar = null;
        public DrawingObjectAntiAirCraftGun(BaseDrawingAntiAirCraftGun drawningCar)
        {
            _drawningCar = drawningCar;
        }
        public ObjectParameters? GetObjectPosition
        {
            get
            {
                if (_drawningCar == null || _drawningCar.AntiAirСraftGun ==
                null)
                {
                    return null;
                }
                return new ObjectParameters(_drawningCar.GetPosX,
                _drawningCar.GetPosY, _drawningCar.GetWidth, _drawningCar.GetHeight);
            }
        }
        public int GetStep => (int)(_drawningCar?.AntiAirСraftGun?.Step ?? 0);
        public bool CheckCanMove(DirectionType direction) =>
        _drawningCar?.CanMove(direction) ?? false;
        public void MoveObject(DirectionType direction) =>
        _drawningCar?.MoveTransport(direction);
    }
}
