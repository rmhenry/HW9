using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }

        public static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Homework 9 \n");
            Console.WriteLine("Main Menu \n");
            Console.WriteLine("1 - Debugging Exercise 11_8");
            Console.WriteLine("2 - Exercise 11_9");
            Console.WriteLine("3 - Exercise 11_17");
            Console.WriteLine("4 - Exercise 11_19");
            Console.WriteLine("5 - Exit\n");
            Console.Write("Please enter a selection: ");

            string userSelection = Console.ReadLine();

            switch (userSelection)
            {
                case "1":
                    DebugTest();
                    break;
                case "2":
                    Ex11_9Test();
                    break;
                case "3":
                    Ex11_17Test();
                    break;
                case "4":
                    Ex11_19Test();
                    break;
                default:
                    Console.Write("Exiting program.");
                    System.Threading.Thread.Sleep(3000);    //keep console open 3 seconds for user to read exit message
                    Environment.Exit(0);
                    break;
            }
        }

        public static void DebugTest()
        {
            Console.Clear();

            string[] arguments = new string[] {"testfile.txt", "3"};
            ReadFile test = new ReadFile();
            test.ReadFileTest(arguments);
            ReturnToMainMenu();
        }

        public static void Ex11_9Test()
        {

        }

        public static void Ex11_17Test()
        {

        }

        public static void Ex11_19Test()
        {

        }

        public static void ReturnToMainMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Press Enter to return to the Main Menu.");
            Console.ReadLine();
            MainMenu();
        }
    }
}
