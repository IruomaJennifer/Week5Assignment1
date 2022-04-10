using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKingdom.Phylia
{
    internal class Arthropoda:Animal,Invertebrate,IAquatic,ITerrestrial,IParasitic
    {
        public string Name { get; set; }
        public int JointedAppendagePairs { get; set; }
        public bool HasCompoundEyes { get; set; } = true;
        public string CirculatorySystemType { get; set; } = "Open";
        public int NoOfSegments { get; set; }
        public bool HasExoSkeleton { get; set; } = true;
        public bool IsVertebrate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool ExistsOnLand { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool ExistsOnWater { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsParasitic { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        void StartSurfaceRespiration()
        {

        }
    }
}
