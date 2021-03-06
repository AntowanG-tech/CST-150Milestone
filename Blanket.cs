using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST_150MilestoneAG
{
    public class Blanket 
    {
            private int id;       //id blanket entry in database
            private string type; //the type of blanket
            private string shape; //the shape of the blanket
            private string color; // the color of the blanket
            private string material; //the material the blanket is made of
            private string size; //general sizes of the blanket
            private double price; // price of the blanket
            private int qty;          //quanity of blankets

            //Blanket object non-default constructor
            public Blanket(int id, string type, string shape, string color, string material, string size, double price, int qty)
            {
                this.id = id;
                this.type = type;
                this.shape = shape;
                this.color = color;
                this.material = material;
                this.size = size;
                this.price = price;
                this.qty = qty;
            }

            //default Blanket constructor
            public Blanket()
            {

            }

            //getters and setters
         public int Id { get; set; }
        public string Type { get; set; }
        public string Shape { get; set; }
        public string Color { get; set; }
        public string Material { get; set; }
        public string Size { get; set; }
        public double Price { get; set; }
        public int Qty { get; set; }

        public override string ToString()
        {
            String blanketString = "ID: " + this.id + Environment.NewLine + "Type: " + type + Environment.NewLine + "Shape: " + shape + Environment.NewLine + "Color: " + color + Environment.NewLine + "Material: " + material + Environment.NewLine + "Size: " + size + Environment.NewLine + "Price: " + price + Environment.NewLine + "Quantity: " + qty;
            return blanketString;
        }

       




    }
}
