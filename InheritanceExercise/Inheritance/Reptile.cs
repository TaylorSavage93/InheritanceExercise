using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        public bool IsColdBlooded { get; set; }
        public string Habitat { get; set; }
        public bool HasScales { get; set; }
        public bool CanGrowTail { get; set; }

    }
}
