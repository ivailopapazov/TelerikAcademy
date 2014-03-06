using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public class AggressionInhibitor : Inhibitor
    {
        private const int HealthEffect = 3;

        public AggressionInhibitor()
            : base(Supplement.BasePowerEffect, Supplement.BaseHealthEffect, AggressionInhibitor.HealthEffect)
        {

        }
    }
}
