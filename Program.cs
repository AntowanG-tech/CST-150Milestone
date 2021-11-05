using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST_150Milestone3
{
    class Program
    {
        static void Main(string[] args)
        {
            InventoryManager inventory = new InventoryManager();
            Blanket[] blanketsArray = inventory.getBlankets();

            inventory.restockBlankets();
            
           
            Console.WriteLine("Press 'x' to close: ");
            Console.WriteLine("Press 'y' to create a blanket: ");
            Console.WriteLine("Press 'z' to display all blankets: ");
            Console.WriteLine("Press 'e' to  search a blanket: ");
            Console.WriteLine("Press 'r' to  remove a blanket: ");
            Console.WriteLine("Press 't' to restock blankets: ");
            Console.Write("Please enter a command: ");
            String input = Console.ReadLine();
            
            while (input != "x")
            {
                if (input == "y")
                {
                    Console.Write("Enter blanket id: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter blanket type: ");
                    String type = Console.ReadLine();
                    Console.Write("Enter blanket shape: ");
                    String shape = Console.ReadLine();
                    Console.Write("Enter blanket color: ");
                    String color = Console.ReadLine();
                    Console.Write("Enter blanket material: ");
                    String material = Console.ReadLine();
                    Console.Write("Enter blanket size: ");
                    String size = Console.ReadLine();
                    Console.Write("Enter blanket price: ");
                    double price = Convert.ToDouble(Console.ReadLine());
                    inventory.createBlanket(id, type, shape, color, material, size, price);
                }
                else if (input == "z")
                {
                    for (int i = 0; i < blanketsArray.Length; i++)
                    {
                        Console.WriteLine(blanketsArray[i].ToString());
                    }
                }
                else if ( input == "e")
                {
                    Console.WriteLine("Enter a blanket type: ");
                    String type = Console.ReadLine();
                    Console.WriteLine("Enter a blanket shape: ");
                    String shape = Console.ReadLine();
                    Blanket [] searchArray = inventory.searchForBlanket(type, shape);
                    for (int i = 0; i < searchArray.Length; i++)
                    {
                        Console.WriteLine(searchArray[i].ToString());
                    }

                }
                else if ( input == "r")
                {
                    Console.Write("Enter blanket position to remove: ");
                    int position = Convert.ToInt32(Console.ReadLine());
                    inventory.removeBlanket(position);
                }
                else if (input == "t")
                {
                    inventory.restockBlankets();
                    Console.WriteLine("Inventory has been restocked");
                }
                else
                {
                    Console.WriteLine("Input not recognized.");
                }

                Console.WriteLine("Press 'x' to close: ");
                Console.WriteLine("Press 'y' to create a blanket: ");
                Console.WriteLine("Press 'z' to display all blankets: ");
                Console.WriteLine("Press 'e' to  search a blanket: ");
                Console.WriteLine("Press 'r' to  remove a blanket: ");
                Console.WriteLine("Press 't' to restock blankets: ");
                Console.Write("Please enter a command: ");
                input = Console.ReadLine();
            }

        }
    }
}
