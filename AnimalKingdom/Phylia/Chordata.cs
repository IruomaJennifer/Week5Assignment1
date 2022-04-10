using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKingdom.Phylia
{
    internal class Chordata : Animal, IVertebrate
    {
        public bool HasABackbone { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    }
}
