
namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;
    using WarMachines.Interfaces;

    public class Pilot : IPilot
    {
        private string name;
        IList<IMachine> machines;

        public Pilot(string name)
        {
            this.Name = name;
            this.machines = new List<IMachine>();
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentNullException("Pilon name cannot be null");
                }
            }
        }

        public void AddMachine(IMachine machine)
        {
            if (machine != null)
            {
                this.machines.Add(machine);
            }
            else
            {
                throw new ArgumentNullException("Machine cannot be null");
            }
        }

        public string Report()
        {
            StringBuilder result = new StringBuilder();

            string pilotName = this.Name;
            string numberOfMachines = this.machines.Count == 0 ? "no" : this.machines.Count.ToString();
            string machineWord = this.machines.Count == 1 ? "machine" : "machines";

            if (numberOfMachines == "no")
            {
                result.Append(string.Format("{0} - {1} {2}", pilotName, numberOfMachines, machineWord));
            }
            else
            {
                result.AppendLine(string.Format("{0} - {1} {2}", pilotName, numberOfMachines, machineWord));
            }

            var sortedMachines = this.machines
                                    .OrderBy(m => m.HealthPoints)
                                    .ThenBy(m => m.Name);

            foreach (var machine in sortedMachines)
            {
                result.Append(machine.ToString());
            }
            return result.ToString();
        }
    }
}
