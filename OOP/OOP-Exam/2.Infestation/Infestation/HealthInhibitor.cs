using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public class HealthInhibitor : Inhibitor
    {
        private const int HealthEffect = 3;

        public HealthInhibitor()
            : base(Supplement.BasePowerEffect, HealthInhibitor.HealthEffect, Supplement.BaseAggressionEffect)
        {

        }
    }
}
