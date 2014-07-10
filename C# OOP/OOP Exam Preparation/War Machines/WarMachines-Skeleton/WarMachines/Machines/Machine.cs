
namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using WarMachines.Interfaces;

    public abstract class Machine : IMachine
    {
        private string name;
        private IPilot pilot;
        private double healthPoints;
        private double attackPoints;
        private double defensePoints;
        IList<string> targets;

        public Machine(string name, double attackPoints, double defensePoints)
        {
            this.Name = name;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
            this.Targets = new List<string>();
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException("Machine name cannot be null or empty");
                }
            }
        }

        public IPilot Pilot
        {
            get { return this.pilot; }
            set
            {
                if (value != null)
                {
                    this.pilot = value;
                }
                else
                {
                    throw new ArgumentNullException("Pilot cannot be null");
                }
            }
        }

        public double HealthPoints
        {
            get { return this.healthPoints; }
            set { this.healthPoints = value; }
        }

        public double AttackPoints
        {
            get { return this.attackPoints; }
            protected set { this.attackPoints = value; }
        }

        public double DefensePoints
        {
            get { return this.defensePoints; }
            protected set { this.defensePoints = value; }
        }

        public IList<string> Targets
        {
            get { return targets; }
            set { this.targets = value; }
        }

        public void Attack(string target)
        {
            if (!string.IsNullOrEmpty(target))
            {
                this.Targets.Add(target);
            }
            else
            {
                throw new ArgumentNullException("Target cannot be null or empty");
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("- " + this.Name);
            result.AppendLine(" *Type: " + this.GetType().Name);
            result.AppendLine(" *Health: " + this.HealthPoints);
            result.AppendLine(" *Attack: " + this.AttackPoints);
            result.AppendLine(" *Defense: " + this.DefensePoints);

            result.Append(" *Targets: ");
            if (this.Targets.Count != 0)
            {
                foreach (var target in this.Targets)
                {
                    result.Append(target + ", ");
                }
                result.Remove(result.Length - 2, 2);
            }
            else
            {
                result.Append("None");
            }
            
            return result.ToString();
        }
    }
}
