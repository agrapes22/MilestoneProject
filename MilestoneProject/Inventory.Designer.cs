namespace MilestoneProject
{
    partial class HomePage
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
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Bahama Breeze",
            "Large",
            "White",
            "1",
            "15.99"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "Pine Dreams",
            "Medium",
            "Green",
            "5",
            "12.99"}, -1);
            this.candleList = new System.Windows.Forms.ListView();
            this.Scent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Color = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.addInvButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.scentSort = new System.Windows.Forms.RadioButton();
            this.sizeSort = new System.Windows.Forms.RadioButton();
            this.colorSort = new System.Windows.Forms.RadioButton();
            this.quantitySort = new System.Windows.Forms.RadioButton();
            this.priceSort = new System.Windows.Forms.RadioButton();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxPanel = new System.Windows.Forms.Panel();
            this.checkBoxPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // candleList
            // 
            this.candleList.AutoArrange = false;
            this.candleList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Scent,
            this.Size,
            this.Color,
            this.Quantity,
            this.Price});
            this.candleList.HideSelection = false;
            this.candleList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3,
            listViewItem4});
            this.candleList.Location = new System.Drawing.Point(206, 146);
            this.candleList.Name = "candleList";
            this.candleList.Size = new System.Drawing.Size(384, 247);
            this.candleList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.candleList.TabIndex = 1;
            this.candleList.UseCompatibleStateImageBehavior = false;
            this.candleList.View = System.Windows.Forms.View.Details;
            // 
            // Scent
            // 
            this.Scent.Text = "Scent";
            this.Scent.Width = 107;
            // 
            // Size
            // 
            this.Size.Text = "Size";
            // 
            // Color
            // 
            this.Color.Text = "Color";
            // 
            // Quantity
            // 
            this.Quantity.Text = "Quantity";
            this.Quantity.Width = 59;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(341, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inventory";
            // 
            // addInvButton
            // 
            this.addInvButton.Location = new System.Drawing.Point(278, 399);
            this.addInvButton.Name = "addInvButton";
            this.addInvButton.Size = new System.Drawing.Size(75, 23);
            this.addInvButton.TabIndex = 3;
            this.addInvButton.Text = "Add";
            this.addInvButton.UseVisualStyleBackColor = true;
            this.addInvButton.Click += new System.EventHandler(this.addInvButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(441, 399);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(278, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 20);
            this.textBox1.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(441, 68);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // scentSort
            // 
            this.scentSort.AutoSize = true;
            this.scentSort.Checked = true;
            this.scentSort.Location = new System.Drawing.Point(3, 12);
            this.scentSort.Name = "scentSort";
            this.scentSort.Size = new System.Drawing.Size(53, 17);
            this.scentSort.TabIndex = 7;
            this.scentSort.TabStop = true;
            this.scentSort.Text = "Scent";
            this.scentSort.UseVisualStyleBackColor = true;
            // 
            // sizeSort
            // 
            this.sizeSort.AutoSize = true;
            this.sizeSort.Location = new System.Drawing.Point(59, 12);
            this.sizeSort.Name = "sizeSort";
            this.sizeSort.Size = new System.Drawing.Size(45, 17);
            this.sizeSort.TabIndex = 8;
            this.sizeSort.Text = "Size";
            this.sizeSort.UseVisualStyleBackColor = true;
            // 
            // colorSort
            // 
            this.colorSort.AutoSize = true;
            this.colorSort.Location = new System.Drawing.Point(110, 12);
            this.colorSort.Name = "colorSort";
            this.colorSort.Size = new System.Drawing.Size(49, 17);
            this.colorSort.TabIndex = 9;
            this.colorSort.Text = "Color";
            this.colorSort.UseVisualStyleBackColor = true;
            // 
            // quantitySort
            // 
            this.quantitySort.AutoSize = true;
            this.quantitySort.Location = new System.Drawing.Point(165, 12);
            this.quantitySort.Name = "quantitySort";
            this.quantitySort.Size = new System.Drawing.Size(64, 17);
            this.quantitySort.TabIndex = 10;
            this.quantitySort.Text = "Quantity";
            this.quantitySort.UseVisualStyleBackColor = true;
            // 
            // priceSort
            // 
            this.priceSort.AutoSize = true;
            this.priceSort.Location = new System.Drawing.Point(235, 12);
            this.priceSort.Name = "priceSort";
            this.priceSort.Size = new System.Drawing.Size(49, 17);
            this.priceSort.TabIndex = 11;
            this.priceSort.Text = "Price";
            this.priceSort.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(619, 129);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "Ascending";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(619, 167);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 13;
            this.button5.Text = "Descending";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(641, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Sort";
            // 
            // checkBoxPanel
            // 
            this.checkBoxPanel.Controls.Add(this.scentSort);
            this.checkBoxPanel.Controls.Add(this.sizeSort);
            this.checkBoxPanel.Controls.Add(this.colorSort);
            this.checkBoxPanel.Controls.Add(this.quantitySort);
            this.checkBoxPanel.Controls.Add(this.priceSort);
            this.checkBoxPanel.Location = new System.Drawing.Point(206, 105);
            this.checkBoxPanel.Name = "checkBoxPanel";
            this.checkBoxPanel.Size = new System.Drawing.Size(384, 35);
            this.checkBoxPanel.TabIndex = 15;
            // 
            // HomePage
            // 
            this.AccessibleName = "HomePage";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBoxPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addInvButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.candleList);
            this.Name = "HomePage";
            this.Text = "Home";
            this.checkBoxPanel.ResumeLayout(false);
            this.checkBoxPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader Scent;
        private System.Windows.Forms.ColumnHeader Size;
        private System.Windows.Forms.ColumnHeader Color;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addInvButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton scentSort;
        private System.Windows.Forms.RadioButton sizeSort;
        private System.Windows.Forms.RadioButton colorSort;
        private System.Windows.Forms.RadioButton quantitySort;
        private System.Windows.Forms.RadioButton priceSort;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel checkBoxPanel;
        public System.Windows.Forms.ListView candleList;
    }
}

