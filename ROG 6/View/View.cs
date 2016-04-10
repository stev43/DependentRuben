using System;
using System.Collections.Generic;

namespace ROG_6.View
{
    class View
    {

        public View()
        {



        }

        public void printStart()
        {
            Console.WriteLine("Welcome to tamagotchi 2016");
            Console.WriteLine("");
            Console.WriteLine("-------------------------------");
            this.printHelp();
        }

        public void printActies(List<string> actions)
        {
            this.PrintSegmentStart();
            Console.WriteLine("Actions:");
            Console.WriteLine("");
            int i = 1;
            foreach (string action in actions)
            {
                Console.WriteLine(i + ". " + action);
                i++;
            }
            this.printSegmentEnd();
        }

        public void printTamagotchiList(List<string> tamagotchis)
        {
            this.PrintSegmentStart();
            int i = 1;
            foreach (string tamagotchi in tamagotchis)
            {
                Console.WriteLine(i + ". " + tamagotchi);
                i++;
            }
            this.printSegmentEnd();
        }

        private void printSegmentEnd()
        {
            Console.WriteLine("");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("");

        }

        private void PrintSegmentStart()
        {
            Console.WriteLine("");
        }

        public void printHelp()
        {
            PrintSegmentStart();
            Console.WriteLine("to enter a command, type the command and press Enter.");
            Console.WriteLine();
            Console.WriteLine("enter \"help\" for help.");
            Console.WriteLine();
            Console.WriteLine("enter \"tamagotchi {number}\" to select the tamagotchi, with {number} being the tamagotchi's number");
            Console.WriteLine("enter \"tamagotchi show\" to get a list of all tamagotchis");
            Console.WriteLine();
            Console.WriteLine("enter \"action {number}\" to interact with an tamagotchi, with {number} being the chosen action");
            Console.WriteLine("enter \"action show\" to get a list of all possible actions");
            Console.WriteLine();
            Console.WriteLine("enter \"create {name}\" to create a new tamagotchi with a name");
            printSegmentEnd();
        }


        public void PrintInvallidCommand(string command)
        {
            PrintSegmentStart();
            Console.WriteLine(command + " is not a valid input");
            printSegmentEnd();
            printHelp();
        }

        public void printParameterError()
        {
            Console.WriteLine("No parameter was given");
            printSegmentEnd();
        }

        public void PrintInvallidParameter(string parameter)
        {
            PrintSegmentStart();
            Console.WriteLine(parameter + " is not a valid parameter.");
            Console.WriteLine("use \"help\" for more more information.");
            printSegmentEnd();
        }

        public void PrintNoTamagotchi()
        {
            PrintSegmentStart();
            Console.WriteLine("You have not selected a tamagotchi");
            Console.WriteLine("You can select a tamagotchi by using tamagotchi {parameter}");
            printSegmentEnd();
        }

        public void PrintTamagotchiInformatie(List<string> data)
        {
            PrintSegmentStart();
            if (data == null || data.Count < 0)
            {
                Console.WriteLine("You have not selected a tamagotchi");
                Console.WriteLine("You can select a tamagotchi by using tamagotchi {parameter}");
            }
            else
            {
                foreach (string s in data)
                {
                    Console.WriteLine(s);
                }
            }
            printSegmentEnd();
        }
    }
}
