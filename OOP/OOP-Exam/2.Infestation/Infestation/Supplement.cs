using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public abstract class Supplement : ISupplement
    {
        protected const int BasePowerEffect = 0;
        protected const int BaseHealthEffect = 0;
        protected const int BaseAggressionEffect = 0;


        protected Supplement(int powerEffect, int healthEffect, int agressionEffect)
        {
            this.PowerEffect = powerEffect;
            this.HealthEffect = healthEffect;
            this.AggressionEffect = agressionEffect;
        }

        public int PowerEffect { get; protected set; }

        public int HealthEffect { get; protected set; }

        public int AggressionEffect { get; protected set; }

        public virtual void ReactTo(ISupplement otherSupplement)
        {
            throw new NotImplementedException();
        }
    }
}
