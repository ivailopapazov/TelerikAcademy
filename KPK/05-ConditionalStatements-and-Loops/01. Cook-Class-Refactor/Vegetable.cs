using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheffClassRefactor
{
    public abstract class Vegetable
    {
        public bool IsPeeled { get; set; }
        public bool IsCuted { get; set; }
        public bool isRotten { get; set; }
    }
}
