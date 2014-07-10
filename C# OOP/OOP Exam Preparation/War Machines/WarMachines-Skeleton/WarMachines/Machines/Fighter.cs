
namespace WarMachines.Machines
{
    using System.Text;
    using WarMachines.Interfaces;

    public class Fighter : Machine, IFighter
    {
        private const int InitialHealthPoints = 200;

        private bool stealthMode;

        public Fighter(string name, double attackPoints, double defensePoints, bool stealthMode)
            : base(name, attackPoints, defensePoints)
        {
            this.StealthMode = stealthMode;
            this.HealthPoints = InitialHealthPoints;
        }

        public bool StealthMode
        {
            get { return this.stealthMode; }
            private set { this.stealthMode = value; }
        }

        public void ToggleStealthMode()
        {
            if (this.StealthMode == true)
            {
                this.StealthMode = false;
            }
            else
            {
                this.StealthMode = true;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            string baseString = base.ToString();
            result.AppendLine(baseString);
            result.Append(string.Format(" *Stealth: {0}", this.StealthMode ? "ON" : "OFF"));
            return result.ToString();
        }
    }
}
