using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public class AdvancedHoldingPen : HoldingPen
    {
        protected override void ExecuteAddSupplementCommand(string[] commandWords)
        {
            Supplement supplement = null;

            switch (commandWords[1])
            {
                case "PowerInhibitor":
                    supplement = new PowerInhibitor();
                    break;
                case "HealthInhibitor":
                    supplement = new HealthInhibitor();
                    break;
                case "AggressionInhibitor":
                    supplement = new AggressionInhibitor();
                    break;
                case "Weapon":
                    supplement = new Weapon();
                    break;
                default:
                    base.ExecuteAddSupplementCommand(commandWords);
                    break;
            }

            if (supplement != null)
            {
                var unit = this.GetUnit(commandWords[2]);
                unit.AddSupplement(supplement);
            }
        }
    }
}
