using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Phones
{
    public static class CommandExecuter
    {
        public static void ExecuteCommands(HashSet<Person> persons, string path)
        {
            var reader = new StreamReader(path);
            var commandsResults = new List<Person[]>();

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

        private static Person[] ExecuteCommand(HashSet<Person> persons, string command)
        {
            var commandArray = command.Split(new char[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
            var commandName = commandArray[0];
            var commandParams = commandArray[1].Split(',');
            switch (commandName)
            {
                case "find":
                    switch (commandParams.Length)
                    {
                        case 1: return FindByName(persons, commandParams); break;
                        case 2: return FindByNameAndTown(persons, commandParams); break;

                        default:
                            throw new ArgumentException("Invalid length of params");
                    }

                default: throw new ArgumentException("Given command does not exist in \"commands.txt\"");
            }
        }

        private static Person[] FindByName(HashSet<Person> persons, string[] commandParams)
        {
            var searchName = commandParams[0].ToLower().Trim();
            var found = persons.Where
                (p => p.Name.ToLower().IndexOf(searchName) != -1).ToArray();
            return found;
        }

        private static Person[] FindByNameAndTown(HashSet<Person> persons, string[] commandParams)
        {
            var searchName = commandParams[0].ToLower().Trim();
            var searchTown = commandParams[1].ToLower().Trim();
            var found = persons.Where
                (p => p.Name.ToLower().IndexOf(searchName) != -1 &&
                    p.Town.ToLower() == searchTown).ToArray();
            return found;
        }

        private static void PrintResults(List<Person[]> commandsResults)
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