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
        private readonly BaseDrawingAntiAirCraftGun? _drawningAntiAirCraftGun = null;
        public DrawingObjectAntiAirCraftGun(BaseDrawingAntiAirCraftGun drawningCar)
        {
            _drawningAntiAirCraftGun = drawningCar;
        }
        public ObjectParameters? GetObjectPosition
        {
            get
            {
                if (_drawningAntiAirCraftGun == null || _drawningAntiAirCraftGun.AntiAirСraftGun ==
                null)
                {
                    return null;
                }
                return new ObjectParameters(_drawningAntiAirCraftGun.GetPosX,
                _drawningAntiAirCraftGun.GetPosY, _drawningAntiAirCraftGun.GetWidth, _drawningAntiAirCraftGun.GetHeight);
            }
        }
        public int GetStep => (int)(_drawningAntiAirCraftGun?.AntiAirСraftGun?.Step ?? 0);
        public bool CheckCanMove(DirectionType direction) =>
        _drawningAntiAirCraftGun?.CanMove(direction) ?? false;
        public void MoveObject(DirectionType direction) =>
        _drawningAntiAirCraftGun?.MoveTransport(direction);
    }
}
