using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AntiAircraftGun.Exceptions
{
    [Serializable]
    internal class AntiAirCraftGunNotFoundException : ApplicationException
    {
        public AntiAirCraftGunNotFoundException(int i) : base($"Не найден объект по позиции {i}") { }
        public AntiAirCraftGunNotFoundException() : base() { }
        public AntiAirCraftGunNotFoundException(string message) : base(message) { }
        public AntiAirCraftGunNotFoundException(string message, Exception exception) : base(message, exception) { }
        protected AntiAirCraftGunNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
