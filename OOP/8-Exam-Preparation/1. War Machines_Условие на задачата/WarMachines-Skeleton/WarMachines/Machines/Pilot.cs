using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    public class Pilot : IPilot
    {
        private string name;
        private IList<IMachine> machines;

        public Pilot(string name)
        {
            this.Name = name;
            this.machines = new List<IMachine>();
        }

        public string Name
        {
            get 
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Pilot's name cannot be null or empty!");
                }

                this.name = value;
            }
        }

        public void AddMachine(IMachine machine)
        {
            if (machine == null)
            {
                throw new ArgumentNullException("Cannot add machine to pilot that is null!");
            }

            machines.Add(machine);
        }

        public string Report()
        {
            StringBuilder report = new StringBuilder();
            string numberOfMachines = string.Empty;
            string machineWord = "machines";

            if (machines.Count == 0)
            {
                numberOfMachines = "no";
            }
            else
            {
                if (machines.Count == 1)
                {
                    machineWord = "machine";
                }

                numberOfMachines = machines.Count.ToString();
            }

            report.AppendFormat("{0} - {1} {2}", this.Name, numberOfMachines, machineWord);

            foreach (var machine in machines)
            {
                report.Append(machine);
            }

            return report.ToString();
        }
    }
}
