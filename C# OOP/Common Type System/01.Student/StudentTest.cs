using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Students
{
    class StudentTest
    {
        static void Main()
        {
            Student pesho = new Student();
            Student misho = new Student();
            pesho.FirstName = "Pesho";
            misho.FirstName = "Misho";
            Console.WriteLine(pesho);
            Console.WriteLine(pesho.Equals(misho));
            Console.WriteLine(pesho.GetHashCode());
            bool equality = (pesho == misho);
            bool difference = (pesho != misho);
            Student clonePesho = (Student)pesho.Clone();

            pesho.MiddleName = "Peshov";
            pesho.LastName = "Peshovski";
            pesho.SSN = 3;
            misho.MiddleName = "Mishov";
            misho.LastName = "Mishovski";
            clonePesho = (Student)pesho.Clone();
            clonePesho.SSN = 3;
            int result = pesho.CompareTo(clonePesho);
            
        }
    }
}
