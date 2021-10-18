using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_150MilestoneAG
{
    public partial class Form1 : Form
    {

        public List<Blanket> Blankets { get; set; }
        public Form1()
        {
            Blankets = GetBlankets();
            InitializeComponent();
        }

        private List<Blanket> GetBlankets()
        {
            var list = new List<Blanket>();
            list.Add(new Blanket() 
            { Id = 1, 
              Type = "Quilt", 
              Shape = "Square", 
              Color = "Multi", 
              Material = "Cotton", 
              Size = "74in x 74in", 
              Price = 75.00 });

            list.Add(new Blanket()
            {
                Id = 2,
                Type = "Comforter",
                Shape = "Rectangle",
                Color = "Grey",
                Material = "Fleece",
                Size = "74in x 92in",
                Price = 43.00
            });

            list.Add(new Blanket()
            {
                Id = 3,
                Type = "Throw",
                Shape = "Square",
                Color = "Red",
                Material = "Wool",
                Size = "32in x 32in",
                Price = 20.00
            });

            return list;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var blankets = this.Blankets;

            dataGridView1.DataSource = blankets;

        }
    }


}
