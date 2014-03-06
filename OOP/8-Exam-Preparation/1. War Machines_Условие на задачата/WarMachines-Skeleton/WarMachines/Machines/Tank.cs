using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    public class Tank : Machine, ITank
    {
        private const double InitialHealthPoints = 100;
        private const double DefenseModeDefenseModifier = 30;
        private const double DefenseModeAttackModifier = -40;

        public Tank(string name, double attackPoints, double defensePoints)
            : base(name, attackPoints, defensePoints, Tank.InitialHealthPoints)
        {
            this.ToggleDefenseMode();
        }

        public bool DefenseMode { get; private set; }

        public void ToggleDefenseMode()
        {
            if (this.DefenseMode)
            {
                // Turning off
                this.DefensePoints -= Tank.DefenseModeDefenseModifier;
                this.AttackPoints -= Tank.DefenseModeAttackModifier;
            }
            else
            {
                // Turning on
                this.DefensePoints += Tank.DefenseModeDefenseModifier;
                this.AttackPoints += Tank.DefenseModeAttackModifier;
            }

            // Toggle defense mode
            this.DefenseMode = !this.DefenseMode;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append(base.ToString());
            result.AppendFormat(" *Defense: {0}", this.DefenseMode ? "ON" : "OFF");

            return result.ToString();
        }
    }
}
