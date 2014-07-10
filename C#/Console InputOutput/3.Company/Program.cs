using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter name of the company: ");
        string companyName = Console.ReadLine();
        Console.WriteLine("Enter adress: ");
        string adress = Console.ReadLine();
        Console.WriteLine("Enter phone number: ");
        int companyPhoneNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter fax number: ");
        int companyFax = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter website: ");
        string Website = Console.ReadLine();
        Console.WriteLine("Enter first name of the manager: ");
        string managerFirstName = Console.ReadLine();
        Console.WriteLine("Enter last name of the manager: ");
        string managerLastName = Console.ReadLine();
        Console.WriteLine("Enter phone number of the manager ");
        int managerPhoneNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("\nName of the company: " + companyName);
        Console.WriteLine("Adress: " + adress);
        Console.WriteLine("Phone number: " + companyPhoneNumber);
        Console.WriteLine("Fax: " + companyFax);
        Console.WriteLine("Website: " + Website);
        Console.WriteLine("Manager's first name: " + managerFirstName);
        Console.WriteLine("Manager's last name: " + managerLastName);
        Console.WriteLine("Manager's phone number: " + managerPhoneNumber);


    }
}

