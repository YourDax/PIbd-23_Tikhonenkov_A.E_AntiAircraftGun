using AntiAircraftGun.Enitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntiAircraftGun.DrawingObjects
{
    public static class ExtentionDrawningAntiAirCraftGun
    {
        public static BaseDrawingAntiAirCraftGun? CreateDrawningAntiAirCraftGun(this string info, char separatorForObject,int width, int height)
        {
            string[] strs = info.Split(separatorForObject);
            if (strs.Length == 4)
            {
                return new BaseDrawingAntiAirCraftGun(Convert.ToInt32(strs[0]),
                    Convert.ToInt32(strs[1]), Color.FromName(strs[2]), Color.FromName(strs[3]),
                    width, height);
            }
            if (strs.Length == 7)
            {
                return new AdvancedDrawingAntiAirCraftGun(Convert.ToInt32(strs[0]),
                    Convert.ToInt32(strs[1]), Color.FromName(strs[2]), Color.FromName(strs[3]),
                    Color.FromName(strs[4]), Convert.ToBoolean(strs[5]), Convert.ToBoolean(strs[6]), width, height);
            }
            return null;
        }

        public static string GetDataForSave(this BaseDrawingAntiAirCraftGun drawningAntiAirCraftGun, char separatorForObject)
        {
            var zenit = drawningAntiAirCraftGun.AntiAirСraftGun;
            if (zenit == null)
            {
                return string.Empty;
            }
            var str = $"{zenit.Speed}{separatorForObject}{zenit.Weight}{separatorForObject}{zenit.BodyColor.Name}{separatorForObject}{zenit.AdditionalColor.Name}";
            if (zenit is not EntityAdvancedAntiAirCraftGun antiAirCraftGun)
            {
                return str;
            }
            return
            $"{str}{separatorForObject}{antiAirCraftGun.DopColor.Name}{separatorForObject}{antiAirCraftGun.Radar}{separatorForObject}{antiAirCraftGun.Rocket}";
        }
    }
}
