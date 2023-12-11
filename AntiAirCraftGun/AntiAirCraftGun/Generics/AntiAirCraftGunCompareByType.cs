using AntiAircraftGun.DrawingObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntiAircraftGun.Generics
{
    internal class AntiAirCraftGunCompareByType : IComparer<BaseDrawingAntiAirCraftGun?>
    {
        public int Compare(BaseDrawingAntiAirCraftGun? x, BaseDrawingAntiAirCraftGun? y)
        {
            if (x == null || x.AntiAirСraftGun == null)
                throw new ArgumentNullException(nameof(x));

            if (y == null || y.AntiAirСraftGun == null)
                throw new ArgumentNullException(nameof(y));

            if (x.GetType().Name != y.GetType().Name)
            {
                return x.GetType().Name.CompareTo(y.GetType().Name);
            }
            var speedCompare = x.AntiAirСraftGun.Speed.CompareTo(y.AntiAirСraftGun.Speed);

            if (speedCompare != 0)
                return speedCompare;

            return x.AntiAirСraftGun.Weight.CompareTo(y.AntiAirСraftGun.Weight);
        }
    }
}
