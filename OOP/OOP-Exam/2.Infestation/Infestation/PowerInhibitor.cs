using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public class PowerInhibitor : Inhibitor
    {
        private const int PowerEffect = 3;

        public PowerInhibitor()
            : base(PowerInhibitor.PowerEffect, Supplement.BaseHealthEffect, Supplement.BaseAggressionEffect)
        {

        }
    }
}
