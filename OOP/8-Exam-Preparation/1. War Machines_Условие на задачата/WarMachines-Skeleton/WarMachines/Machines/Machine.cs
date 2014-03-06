using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    public abstract class Machine : IMachine
    {
        private string name;
        private IPilot pilot;
        private double healthPoints;
        private IList<string> targets;


        public Machine(string name, double attackPoints, double defensePoints, double initialHealthPoints)
        {
            this.Name = name;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
            this.healthPoints = initialHealthPoints;
            this.pilot = null;
            this.targets = new List<string>();
        }


        public double AttackPoints { get; protected set; }
        public double DefensePoints { get; protected set; }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Machine's name cannot be null or empty!");
                }

                this.name = value;
            }
        }

        public IPilot Pilot
        {
            get
            {
                return this.pilot;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Machine's pilot cannot be null!");
                }

                this.pilot = value;
            }
        }

        public double HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                // TODO: negative health check
                this.healthPoints = value;
            }
        }

        public IList<string> Targets
        {
            get 
            {
                // Some bug here, than return the same instance
                return this.targets;
            }
        }

        public void Attack(string target)
        {
            if (string.IsNullOrEmpty(target))
            {
                throw new ArgumentNullException("Target cannot be null or empty!");
            }

            this.targets.Add(target);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            string machineTargets = "None";
            if (this.targets.Count > 0)
            {
                machineTargets = string.Join(", ", this.targets);
            }

            result.AppendLine();
            result.AppendFormat("- {0}", this.Name).AppendLine();
            result.AppendFormat(" *Type: {0}", this.GetType().Name).AppendLine();
            result.AppendFormat(" *Health: {0}", this.HealthPoints).AppendLine();
            result.AppendFormat(" *Attack: {0}", this.AttackPoints).AppendLine();
            result.AppendFormat(" *Defense: {0}", this.DefensePoints).AppendLine();
            result.AppendFormat(" *Targets: {0}", machineTargets).AppendLine();

            return result.ToString();
        }
    }
}
