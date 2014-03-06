using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public class InfestationSpores : Supplement
    {
        protected const int PowerEffect = -1;
        protected const int AggressionEffect = 20;

        public InfestationSpores()
            : base(InfestationSpores.PowerEffect, Supplement.BaseHealthEffect, InfestationSpores.AggressionEffect)
        {
        }


    }
}
