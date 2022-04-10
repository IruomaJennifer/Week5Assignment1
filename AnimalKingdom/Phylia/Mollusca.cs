using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKingdom.Phylia
{
    internal class Mollusca : Animal, Invertebrate,ITerrestrial,IAquatic
    {
        public string Name { get; set; }
        public int NoOfSegments { get; set; } = 0;
        public bool IsVertebrate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool ExistsOnLand { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool ExistsOnWater { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
