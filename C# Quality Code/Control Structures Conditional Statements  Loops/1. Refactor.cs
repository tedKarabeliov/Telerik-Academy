namespace Control_Structures_Conditional_Statements__Loops
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Chef
    {
        private Bowl GetBowl()
        {   
            //... 
        }

        private Carrot GetCarrot()
        {
            //...
        }

        private Potato GetPotato()
        {
            //...
        }
        private void Cut(Vegetable potato)
        {
            //...
        } 
        public void Cook()
        {
            Potato potato = GetPotato();
            Carrot carrot = GetCarrot();

            Bowl bowl;

            Peel(potato);
            Peel(carrot);
            bowl = GetBowl();

            Cut(potato);
            Cut(carrot);

            bowl.Add(carrot);               
            bowl.Add(potato);
        }
        
    }

}
