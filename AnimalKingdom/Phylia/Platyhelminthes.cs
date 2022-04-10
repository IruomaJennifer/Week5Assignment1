using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKingdom.Phylia
{
    internal class Platyhelminthes:Animal,Invertebrate,IParasitic
    {
        public int RespiratorySystems { get; set; } = 0;
        public string Shape { get; set; } = "flat";
        public bool IsVertebrate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsParasitic { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        void GetOxygenByDiffusion()
        {

        }
    }
}
