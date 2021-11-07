
namespace CST_150MilestoneAG
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.search_btn = new System.Windows.Forms.Button();
            this.remove_btn = new System.Windows.Forms.Button();
            this.restock_btn = new System.Windows.Forms.Button();
            this.addItem_btn = new System.Windows.Forms.Button();
            this.quantity_txtbox = new System.Windows.Forms.TextBox();
            this.price_txtbox = new System.Windows.Forms.TextBox();
            this.size_txtbox = new System.Windows.Forms.TextBox();
            this.material_txtbox = new System.Windows.Forms.TextBox();
            this.color_txtbox = new System.Windows.Forms.TextBox();
            this.shape_txtbox = new System.Windows.Forms.TextBox();
            this.type_txtbox = new System.Windows.Forms.TextBox();
            this.id_txtbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searching_txtbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Blanket Inventory Management System";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 597);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(924, 352);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.searching_txtbox);
            this.panel1.Controls.Add(this.search_btn);
            this.panel1.Controls.Add(this.remove_btn);
            this.panel1.Controls.Add(this.restock_btn);
            this.panel1.Controls.Add(this.addItem_btn);
            this.panel1.Controls.Add(this.quantity_txtbox);
            this.panel1.Controls.Add(this.price_txtbox);
            this.panel1.Controls.Add(this.size_txtbox);
            this.panel1.Controls.Add(this.material_txtbox);
            this.panel1.Controls.Add(this.color_txtbox);
            this.panel1.Controls.Add(this.shape_txtbox);
            this.panel1.Controls.Add(this.type_txtbox);
            this.panel1.Controls.Add(this.id_txtbox);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(-7, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(988, 953);
            this.panel1.TabIndex = 3;
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(119, 573);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 23);
            this.search_btn.TabIndex = 22;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // remove_btn
            // 
            this.remove_btn.Location = new System.Drawing.Point(577, 513);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(75, 23);
            this.remove_btn.TabIndex = 21;
            this.remove_btn.Text = "Remove";
            this.remove_btn.UseVisualStyleBackColor = true;
            this.remove_btn.Click += new System.EventHandler(this.remove_btn_Click);
            // 
            // restock_btn
            // 
            this.restock_btn.Location = new System.Drawing.Point(474, 513);
            this.restock_btn.Name = "restock_btn";
            this.restock_btn.Size = new System.Drawing.Size(75, 23);
            this.restock_btn.TabIndex = 20;
            this.restock_btn.Text = "Restock";
            this.restock_btn.UseVisualStyleBackColor = true;
            this.restock_btn.Click += new System.EventHandler(this.restock_btn_Click);
            // 
            // addItem_btn
            // 
            this.addItem_btn.Location = new System.Drawing.Point(366, 512);
            this.addItem_btn.Name = "addItem_btn";
            this.addItem_btn.Size = new System.Drawing.Size(75, 23);
            this.addItem_btn.TabIndex = 19;
            this.addItem_btn.Text = "Add";
            this.addItem_btn.UseVisualStyleBackColor = true;
            this.addItem_btn.Click += new System.EventHandler(this.addItem_btn_Click);
            // 
            // quantity_txtbox
            // 
            this.quantity_txtbox.Location = new System.Drawing.Point(190, 514);
            this.quantity_txtbox.Name = "quantity_txtbox";
            this.quantity_txtbox.Size = new System.Drawing.Size(100, 22);
            this.quantity_txtbox.TabIndex = 17;
            // 
            // price_txtbox
            // 
            this.price_txtbox.Location = new System.Drawing.Point(190, 447);
            this.price_txtbox.Name = "price_txtbox";
            this.price_txtbox.Size = new System.Drawing.Size(100, 22);
            this.price_txtbox.TabIndex = 16;
            // 
            // size_txtbox
            // 
            this.size_txtbox.Location = new System.Drawing.Point(190, 392);
            this.size_txtbox.Name = "size_txtbox";
            this.size_txtbox.Size = new System.Drawing.Size(100, 22);
            this.size_txtbox.TabIndex = 15;
            // 
            // material_txtbox
            // 
            this.material_txtbox.Location = new System.Drawing.Point(190, 347);
            this.material_txtbox.Name = "material_txtbox";
            this.material_txtbox.Size = new System.Drawing.Size(100, 22);
            this.material_txtbox.TabIndex = 14;
            // 
            // color_txtbox
            // 
            this.color_txtbox.Location = new System.Drawing.Point(190, 298);
            this.color_txtbox.Name = "color_txtbox";
            this.color_txtbox.Size = new System.Drawing.Size(100, 22);
            this.color_txtbox.TabIndex = 13;
            // 
            // shape_txtbox
            // 
            this.shape_txtbox.Location = new System.Drawing.Point(190, 246);
            this.shape_txtbox.Name = "shape_txtbox";
            this.shape_txtbox.Size = new System.Drawing.Size(100, 22);
            this.shape_txtbox.TabIndex = 12;
            // 
            // type_txtbox
            // 
            this.type_txtbox.Location = new System.Drawing.Point(190, 199);
            this.type_txtbox.Name = "type_txtbox";
            this.type_txtbox.Size = new System.Drawing.Size(100, 22);
            this.type_txtbox.TabIndex = 11;
            // 
            // id_txtbox
            // 
            this.id_txtbox.Location = new System.Drawing.Point(190, 152);
            this.id_txtbox.Name = "id_txtbox";
            this.id_txtbox.Size = new System.Drawing.Size(100, 22);
            this.id_txtbox.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(55, 514);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Quantity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(67, 447);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 392);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Size";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Material";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Shape";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID";
            // 
            // searching_txtbox
            // 
            this.searching_txtbox.Location = new System.Drawing.Point(19, 574);
            this.searching_txtbox.Name = "searching_txtbox";
            this.searching_txtbox.Size = new System.Drawing.Size(100, 22);
            this.searching_txtbox.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(208, 575);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(223, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "search for a specific blanket here*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(970, 580);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox quantity_txtbox;
        private System.Windows.Forms.TextBox price_txtbox;
        private System.Windows.Forms.TextBox size_txtbox;
        private System.Windows.Forms.TextBox material_txtbox;
        private System.Windows.Forms.TextBox color_txtbox;
        private System.Windows.Forms.TextBox shape_txtbox;
        private System.Windows.Forms.TextBox type_txtbox;
        private System.Windows.Forms.TextBox id_txtbox;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button remove_btn;
        private System.Windows.Forms.Button restock_btn;
        private System.Windows.Forms.Button addItem_btn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox searching_txtbox;
    }

}

