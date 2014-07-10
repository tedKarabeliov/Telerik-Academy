
namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using WarMachines.Interfaces;

    public class Tank : Machine, ITank
    {
        private const int InitialHealthPoints = 100;
        private const int AttackPointsModifier = 40;
        private const int DefensePointsModifier = 30;

        private bool defenseMode;

        public Tank(string name, double attackPoints, double defensePoints)
            : base(name, attackPoints, defensePoints)
        {
            this.ToggleDefenseMode();
            this.HealthPoints = InitialHealthPoints;
        }

        public bool DefenseMode
        {
            get { return this.defenseMode; }
            private set { this.defenseMode = value; }
        }

        public void ToggleDefenseMode()
        {
            if (this.DefenseMode == true)
            {
                this.AttackPoints += AttackPointsModifier;
                this.DefensePoints -= DefensePointsModifier;
                this.DefenseMode = false;
            }
            else
            {
                this.AttackPoints -= AttackPointsModifier;
                this.DefensePoints += DefensePointsModifier;
                this.defenseMode = true;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            string baseString = base.ToString();
            result.AppendLine(baseString);
            result.Append(" *Defense: ");
            if (this.DefenseMode == true)
            {
                result.AppendLine("ON");
            }
            else
            {
                result.AppendLine("OFF");
            }

            return result.ToString();
        }
    }
}
