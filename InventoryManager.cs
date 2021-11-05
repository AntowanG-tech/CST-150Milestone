using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST_150Milestone3
{
    class InventoryManager
    {
        Blanket[] blankets = new Blanket[5];

        public void createBlanket(int id, string type, string shape, string color, string material, string size, double price)
        {
            //Method will create a blanket object to be placed in array
            Blanket newBlanket = new Blanket(id, type, shape, color, material, size, price);
            bool ifBlanketWasAssigned = false;

            for (int i = 0; i < blankets.Length; i++)
            {
                if ( blankets[i] == null)
                {
                    blankets[i] = newBlanket;
                    ifBlanketWasAssigned = true;
                    break;
                }
            }

            if(ifBlanketWasAssigned == false)
            {
                Console.WriteLine("Blanket could not be populated in the array.");
            }


        }

        public void removeBlanket(int blanketID) 
        {
            Console.WriteLine(blanketID);
            
             blankets = blankets.Where((source, index) => index != blanketID).ToArray();

            for (int i = 0; i < blankets.Length; i++)
            {
                Console.WriteLine(blankets[i].ToString());
            }

        }

        public void restockBlankets()
        {
            if (blankets[0] == null) 
            {
                blankets[0] = new Blanket(0, "quilt", "circle", "grey", "fleece", "72x72", 70.00d);
            }
            if (blankets[1] == null)
            {
                blankets[1] = new Blanket(1, "quilt", "square", "dark blue", "cotton", "72x72", 55.00d);
            }
            if (blankets[2] == null)
            {
                blankets[2] = new Blanket(2, "throw", "rectangle", "pink", "wool", "72x72", 60.00d);
            }
            if (blankets[3] == null)
            {
                blankets[3] = new Blanket(3, "comforter", "square", "brown", "cotton", "72x72", 48.00d);
            }
            if (blankets[4] == null)
            {
                blankets[4] = new Blanket(4, "quilt", "star", "dark green", "polyester", "32x72x43", 55.00d);
            }
        }

        public Blanket[] getBlankets()
        {
            

            return blankets;
        }

        public Blanket[] searchForBlanket(string type, string shape)
        {
            Blanket[] blanketSearchArray = new Blanket[blankets.Length];
                for (int i = 0; i < blankets.Length; i++)
                {
                if (blankets[i] != null && blankets[i].Type != null && blankets[i].Type.Contains(type))
                {
                    blanketSearchArray[i] = blankets[i];
                }
                if (blankets[i] != null && blankets[i].Shape != null && blankets[i].Shape.Contains(shape))
                {
                    blanketSearchArray[i] = blankets[i];
                }
            }
            return blanketSearchArray;
        }

           

    }
}
