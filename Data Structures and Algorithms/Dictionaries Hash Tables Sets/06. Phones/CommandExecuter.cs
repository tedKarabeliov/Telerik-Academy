using System;
using System.Collections.Generic;
using System.IO;
using Wintellect.PowerCollections;

namespace Phones
{
    public static class CommandExecuter
    {
        public static void ExecuteCommands(Bag<Person> persons, string path)
        {
            var reader = new StreamReader(path);
            var commandsResults = new List<IEnumerable<Person>>();

            using (reader)
            {
                var command = reader.ReadLine();

                while (command != null)
                {
                    var resultOfCurrentCommand = ExecuteCommand(persons, command.Trim());
                    commandsResults.Add(resultOfCurrentCommand);
                    command = reader.ReadLine();
                }
            }

            PrintResults(commandsResults);
        }

        private static IEnumerable<Person> ExecuteCommand(Bag<Person> persons, string command)
        {
            var commandArray = command.Split(new char[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
            var commandName = commandArray[0];
            var commandParams = commandArray[1].Split(',');
            switch (commandName)
            {
                case "find":
                    switch (commandParams.Length)
                    {
                        case 1: return FindByName(persons, commandParams);
                        case 2: return FindByNameAndTown(persons, commandParams);

                        default:
                            throw new ArgumentException("Invalid length of params");
                    }

                default: throw new ArgumentException("Given command does not exist in \"commands.txt\"");
            }
        }

        private static IEnumerable<Person> FindByName(Bag<Person> persons, string[] commandParams)
        {
            var searchName = commandParams[0].ToLower().Trim();
            var foundByName = persons.FindAll(delegate(Person person)
            {
                return person.Name.ToLower().Contains(searchName);
            });
            return foundByName;
        }

        private static IEnumerable<Person> FindByNameAndTown(Bag<Person> persons, string[] commandParams)
        {
            var searchName = commandParams[0].ToLower().Trim();
            var searchTown = commandParams[1].ToLower().Trim();
            var foundByNameAndTown = persons.FindAll(delegate(Person person)
            {
                return person.Name.ToLower().Contains(searchName) &&
                    person.Town.ToLower().Contains(searchTown);
            });

            return foundByNameAndTown;
        }

        private static void PrintResults(List<IEnumerable<Person>> commandsResults)
        {
            Console.WriteLine("Results of commands: ");
            for (int i = 0; i < commandsResults.Count; i++)
            {
                Console.WriteLine("Result of command " + (i + 1) + ':');
                var currentCommandResult = commandsResults[i];
                foreach (var person in currentCommandResult)
                {
                    Console.WriteLine(person);
                }
            }
        }
    }
}