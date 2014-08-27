using System;
using System.Collections.Generic;
using Wintellect.PowerCollections;

namespace Phones
{
    public class PhonesTest
    {
        static void Main()
        {
            var personsArray = TextParser.Parse("../../phones.txt");

            var persons = new Bag<Person>();

            for (int i = 0; i < personsArray.Length; i++)
            {
                var name = personsArray[i][0];
                var town = personsArray[i][1];
                var number = personsArray[i][2];
                var newPerson = new Person(name, town, number);
                persons.Add(newPerson);
            }

            CommandExecuter.ExecuteCommands(persons, "../../commands.txt");
        }
    }
}
