using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntiAircraftGun.Generics
{
    internal class AntiAirCraftGunCollectionInfo : IEquatable<AntiAirCraftGunCollectionInfo>
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public AntiAirCraftGunCollectionInfo(string name, string description)
        {
            Name = name;
            Description = description;
        }
        public bool Equals(AntiAirCraftGunCollectionInfo? other)
        {
            return Name == other.Name;
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }
    }
}
