namespace WarMachines.Engine
{
    using WarMachines.Interfaces;
    using WarMachines.Machines;

    public class MachineFactory : IMachineFactory
    {
        public IPilot HirePilot(string name)
        {
            IPilot pilot = new Pilot(name);
            return pilot;
        }

        public ITank ManufactureTank(string name, double attackPoints, double defensePoints)
        {
            ITank tank = new Tank(name, attackPoints, defensePoints);
            return tank;
        }

        public IFighter ManufactureFighter(string name, double attackPoints, double defensePoints, bool stealthMode)
        {
            IFighter fighter = new Fighter(name, attackPoints, defensePoints, stealthMode);
            return fighter;
        }
    }
}
