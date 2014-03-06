using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public class Weapon : Supplement
    {
        private const int PowerEffect = 10;
        private const int AggressionEffect = 3;

        public Weapon()
            : base(Supplement.BasePowerEffect, Supplement.BaseHealthEffect, Supplement.BaseAggressionEffect)
        {
        }

        public override void ReactTo(ISupplement otherSupplement)
        {
            if (otherSupplement.GetType().Name == "WeaponrySkill")
            {
                this.ActivateSupplement();
            }
            base.ReactTo(otherSupplement);
        }

        public void ActivateSupplement()
        {
            base.PowerEffect = Weapon.PowerEffect;
            base.AggressionEffect = Weapon.AggressionEffect;
        } 
    }
}
