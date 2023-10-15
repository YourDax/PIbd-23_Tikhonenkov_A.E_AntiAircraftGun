using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntiAircraftGun.Enitites
{
    public class EntityAdvancedAntiAirCraftGun : EntityAntiAirCraftGun
    {
        
        public Color DopColor { get; private set; }

        public bool Rocket { get; private set; }

        public bool Radar { get; private set; }



        public EntityAdvancedAntiAirCraftGun(int speed, double weight, Color bodyColor, Color additionalColor,Color dopColor, bool rocket, bool radar)
            : base(speed, weight, bodyColor, additionalColor)
        {
            DopColor = dopColor;
            Rocket = rocket;
            Radar = radar;
        }
    }
}
