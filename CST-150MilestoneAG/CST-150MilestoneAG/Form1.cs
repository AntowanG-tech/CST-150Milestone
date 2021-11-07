using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CST_150MilestoneAG
{
    public partial class Form1 : Form
    {

        public BindingList<Blanket> blankets { get; set; }

        public Form1()
        {
            this.blankets = new BindingList<Blanket>();
            restock();
            InitializeComponent();
        }

        private void restock()
        {
            bool b1 = true;
            bool b2 = true;
            bool b3 = true;

            foreach (Blanket b in blankets)
            {
                if(b.Id == 1)
                {
                    b1 = false;
                }
                if (b.Id == 2)
                {
                    b2 = false;
                }
                if (b.Id == 3)
                {
                    b3 = false;
                }
            }

            if (b1)
            {
                blankets.Add(new Blanket()
                {
                    Id = 1,
                    Type = "Quilt",
                    Shape = "Square",
                    Color = "Multi",
                    Material = "Cotton",
                    Size = "74in x 74in",
                    Price = 75.00,
                    Qty = 19
                });
            }

            if (b2)
            {
                blankets.Add(new Blanket()
                {
                    Id = 2,
                    Type = "Comforter",
                    Shape = "Rectangle",
                    Color = "Grey",
                    Material = "Fleece",
                    Size = "74in x 92in",
                    Price = 43.00,
                    Qty = 7
                });
            }

            if (b3)
            {
                blankets.Add(new Blanket()
                {
                    Id = 3,
                    Type = "Throw",
                    Shape = "Square",
                    Color = "Red",
                    Material = "Wool",
                    Size = "32in x 32in",
                    Price = 20.00,
                    Qty = 15
                });
            }
            
            
           

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //var blankets = this.blankets;

            dataGridView1.DataSource = blankets;
            MessageBox.Show("Welcom to the Blanket Inventory Management System!!");

        }

        private void addItem_btn_Click(object sender, EventArgs e)
        {
            int blanketId = Convert.ToInt32(id_txtbox.Text);
            string blanketType = type_txtbox.Text;
            string blanketShape = shape_txtbox.Text;
            string blanketColor = color_txtbox.Text;
            string blanketMaterial = material_txtbox.Text;
            string blanketSize = size_txtbox.Text;
            double blanketPrice = Convert.ToDouble(price_txtbox.Text);
            int blanketQty = Convert.ToInt32(quantity_txtbox.Text);

            blankets.Add(new Blanket()
            {
                Id = blanketId,
                Type = blanketType,
                Shape = blanketShape,
                Color = blanketColor,
                Material = blanketMaterial,
                Size = blanketSize,
                Price = blanketPrice,
                Qty = blanketQty
            });

            id_txtbox.Clear();
            type_txtbox.Clear();
            shape_txtbox.Clear();
            color_txtbox.Clear();
            material_txtbox.Clear();
            size_txtbox.Clear();
            price_txtbox.Clear();
            quantity_txtbox.Clear();






        }

        private void restock_btn_Click(object sender, EventArgs e)
        {
            restock();
            dataGridView1.DataSource = blankets;
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            List<Blanket> filteredSearchList = new List<Blanket>();
            string searchCriteria = searching_txtbox.Text;
            
            foreach (Blanket b in blankets)
            {
                if (b.Type != null && b.Type.Contains(searchCriteria))
                {
                    filteredSearchList.Add(b);
                }
                if (b.Shape != null && b.Shape.Contains(searchCriteria))
                {
                    filteredSearchList.Add(b);
                }
                if (b.Color != null && b.Color.Contains(searchCriteria))
                {
                    filteredSearchList.Add(b);
                }
                if (b.Material != null && b.Material.Contains(searchCriteria))
                {
                    filteredSearchList.Add(b);
                }
                if (b.Size != null && b.Size.Contains(searchCriteria))
                {
                    filteredSearchList.Add(b);
                }
                if (b.Price.ToString().Contains(searchCriteria))
                {
                    filteredSearchList.Add(b);
                }
                if (b.Qty.ToString().Contains(searchCriteria))
                {
                    filteredSearchList.Add(b);
                }
            }
            dataGridView1.DataSource = filteredSearchList;
            dataGridView1.Update();
            dataGridView1.Refresh();
            
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            List<int> selectedIds = new List<int>();
           foreach (DataGridViewRow row in dataGridView1.SelectedRows) 
            {
                selectedIds.Add(Convert.ToInt32(row.Cells["Id"].Value.ToString()));
            }

           foreach (int ids in selectedIds)
            {
                for (int i = 0; i < blankets.Count(); ++i)
                {
                    if (blankets[i].Id == ids)
                    {
                        blankets.RemoveAt(i);
                      /**  try
                        {
                            int rowIndex = dataGridView1.CurrentCell.RowIndex;
                            dataGridView1.Rows.RemoveAt(rowIndex);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }*/
                        break;
                    }
                }
            }

            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void exportExcel_btn_Click(object sender, EventArgs e)
        {
            //Creating DataTable.
            DataTable dt = getDataTable();

           

            //Exporting to Excel.
            string folderPath = "C:\\Excel\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(dt, "Blankets");

                //Set the color of Header Row.
                //A resembles First Column while C resembles Third column.
                wb.Worksheet(1).Cells("A1:C1").Style.Fill.BackgroundColor = XLColor.DarkGreen;
                for (int i = 1; i <= dt.Rows.Count; i++)
                {
                    //A resembles First Column while C resembles Third column.
                    //Header row is at Position 1 and hence First row starts from Index 2.
                    string cellRange = string.Format("A{0}:C{0}", i + 1);
                    if (i % 2 != 0)
                    {
                        wb.Worksheet(1).Cells(cellRange).Style.Fill.BackgroundColor = XLColor.GreenYellow;
                    }
                    else
                    {
                        wb.Worksheet(1).Cells(cellRange).Style.Fill.BackgroundColor = XLColor.Yellow;
                    }

                }
                //Adjust widths of Columns.
                wb.Worksheet(1).Columns().AdjustToContents();

                //Save the Excel file.
                wb.SaveAs(folderPath + "DataGridViewExport.xlsx");
            }
        }

        public DataTable getDataTable()
        {
            DataTable dt = new DataTable();         //creating a new Data Table
            dt.Columns.Add("Id");                  //adding the columns
            dt.Columns.Add("Type");
            dt.Columns.Add("Shape");
            dt.Columns.Add("Color");
            dt.Columns.Add("Material");
            dt.Columns.Add("Size");
            dt.Columns.Add("Price");
            dt.Columns.Add("Qty");

            DataRow dr = null;
            foreach (DataGridViewRow row in dataGridView1.Rows)    //adding the rows
            {
                dr = dt.NewRow();
                dr["Id"] = row.Cells["Id"].Value;
                dr["Type"] = row.Cells["Type"].Value;
                dr["Shape"] = row.Cells["Shape"].Value;
                dr["Color"] = row.Cells["Color"].Value;
                dr["Material"] = row.Cells["Material"].Value;
                dr["Size"] = row.Cells["Size"].Value;
                dr["Price"] = row.Cells["Price"].Value;
                dr["Qty"] = row.Cells["Qty"].Value;
                dt.Rows.Add(dr);
            }
            return dt;                          //returns the data table
        }
    }


}
