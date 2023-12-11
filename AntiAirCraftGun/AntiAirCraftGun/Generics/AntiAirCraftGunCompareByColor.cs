using AntiAircraftGun.DrawingObjects;
using AntiAircraftGun.Enitites;
using AntiAircraftGun.MovementStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntiAircraftGun.Generics
{
    internal class AntiAirCraftGunCompareByColor : IComparer<BaseDrawingAntiAirCraftGun?>
    {
        public int Compare(BaseDrawingAntiAirCraftGun? x, BaseDrawingAntiAirCraftGun? y)
        {
            if (x == null && y == null)
            {
                // Оба объекта равны
                return 0;
            }
            if (x == null && y != null)
            {
                // Объект x меньше
                return 1;
            }
            if (x != null && y == null)
            {
                // Объект x больше
                return -1;
            }
            var xAntiAircraftGun = x as BaseDrawingAntiAirCraftGun;
            var yAntiAircraftGun = y as BaseDrawingAntiAirCraftGun;

            if (xAntiAircraftGun == null && yAntiAircraftGun == null)
            {
                return 0;
            }
            if (xAntiAircraftGun == null && yAntiAircraftGun != null)
            {
                return 1;
            }
            if (xAntiAircraftGun != null && yAntiAircraftGun == null)
            {
                return -1;
            }
            if (xAntiAircraftGun.AntiAirСraftGun.BodyColor == yAntiAircraftGun.AntiAirСraftGun.BodyColor)
            {
                // Объекты равны по цвету
                return 0;
            }   
            if (xAntiAircraftGun.AntiAirСraftGun.BodyColor.R.CompareTo(yAntiAircraftGun.AntiAirСraftGun.BodyColor.R) == 0)
            {
                if (xAntiAircraftGun.AntiAirСraftGun.BodyColor.G.CompareTo(yAntiAircraftGun.AntiAirСraftGun.BodyColor.G) == 0)
                {
                    // Сравнение по компоненте B, если R и G совпадают
                    return xAntiAircraftGun.AntiAirСraftGun.BodyColor.B.CompareTo(yAntiAircraftGun.AntiAirСraftGun.BodyColor.B);
                }
                else
                {
                    // Сравнение по компоненте G, если R совпадает, но G не совпадает
                    return xAntiAircraftGun.AntiAirСraftGun.BodyColor.G.CompareTo(yAntiAircraftGun.AntiAirСraftGun.BodyColor.G);
                }
            }
            else
            {
                // Сравнение по компоненте R, если R не совпадает
                return xAntiAircraftGun.AntiAirСraftGun.BodyColor.R.CompareTo(yAntiAircraftGun.AntiAirСraftGun.BodyColor.R);
            }

        }

    }
}
