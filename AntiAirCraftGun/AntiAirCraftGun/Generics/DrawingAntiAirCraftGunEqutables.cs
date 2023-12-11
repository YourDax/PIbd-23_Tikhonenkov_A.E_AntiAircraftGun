using AntiAircraftGun.DrawingObjects;
using AntiAircraftGun.Enitites;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntiAircraftGun.Generics
{
    internal class DrawingAntiAirCraftGunEqutables : IEqualityComparer<BaseDrawingAntiAirCraftGun?>
    {
        public bool Equals(BaseDrawingAntiAirCraftGun? x, BaseDrawingAntiAirCraftGun? y)
        {
            if (x == null || x.AntiAirСraftGun == null)
            {
                throw new ArgumentNullException(nameof(x));
            }
            if (y == null || y.AntiAirСraftGun == null)
            {
                throw new ArgumentNullException(nameof(y));
            }
            if (x.GetType().Name != y.GetType().Name)
            {
                return false;
            }
            if (x.AntiAirСraftGun.Speed != y.AntiAirСraftGun.Speed)
            {
                return false;
            }
            if (x.AntiAirСraftGun.Weight != y.AntiAirСraftGun.Weight)
            {
                return false;
            }
            if (x.AntiAirСraftGun.BodyColor != y.AntiAirСraftGun.BodyColor)
            {
                return false;
            }
            if (x is AdvancedDrawingAntiAirCraftGun && y is AdvancedDrawingAntiAirCraftGun)
            {
                EntityAdvancedAntiAirCraftGun EntityX = (EntityAdvancedAntiAirCraftGun)x.AntiAirСraftGun;
                EntityAdvancedAntiAirCraftGun EntityY = (EntityAdvancedAntiAirCraftGun)y.AntiAirСraftGun;
                if (EntityX.Radar != EntityY.Radar)
                    return false;
                if (EntityX.Rocket != EntityY.Rocket)
                    return false;
                if (EntityX.DopColor != EntityY.DopColor)
                    return false;
            }
            return true;
        }

        public int GetHashCode([DisallowNull] BaseDrawingAntiAirCraftGun obj)
        {
            return obj.GetHashCode();
        }
    }
}
