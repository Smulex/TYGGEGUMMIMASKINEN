using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TYGGEGUMMIMASKINEN
{
    class Program
    {
        static void Main(string[] args)
        {
            Machine machine = new Machine();
            bool throwOut = true;
            do
            {
                Console.Clear();

                Console.WriteLine("\tEnter - To get gum");
                Console.WriteLine("\tSpace - To fill Machine");
                Console.WriteLine("\tEscape - To throw the machine out\n");

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.Enter:
                        if (machine.CheckEmpty() == true)
                        {
                            Console.WriteLine(machine.GetGum());
                        }
                        else
                        {
                            Console.WriteLine("You got a gum. Taste: " + machine.GetGum());
                        }
                        break;
                    case ConsoleKey.Spacebar:
                        if (machine.CheckEmpty() == true)
                        {
                            machine.Fill();
                            Console.WriteLine("The machine is filled");
                        }
                        else
                        {
                            Console.WriteLine("Machine not empty! Refill not needed");
                        }
                        break;
                    case ConsoleKey.Escape:
                        if (machine.CheckEmpty() == true)
                        {
                            Console.WriteLine("The machine has been thrown out!");
                            throwOut = false;
                        }
                        else
                        {
                            Console.WriteLine("The machine is not empty");
                        }
                        break;
                    default:
                        break;
                }
                Console.ReadKey();
            } while (throwOut);
        }
    }
}
