using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public class WeaponrySkill : Supplement
    {
        public WeaponrySkill()
            : base(Supplement.BasePowerEffect, Supplement.BaseHealthEffect, Supplement.BaseAggressionEffect)
        {
        }

    }
}
