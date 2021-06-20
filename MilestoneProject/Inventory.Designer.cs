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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.candleList = new System.Windows.Forms.ListView();
            this.Scent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Color = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.addInvButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.scentSort = new System.Windows.Forms.RadioButton();
            this.sizeSort = new System.Windows.Forms.RadioButton();
            this.colorSort = new System.Windows.Forms.RadioButton();
            this.quantitySort = new System.Windows.Forms.RadioButton();
            this.priceSort = new System.Windows.Forms.RadioButton();
            this.ascendingSort = new System.Windows.Forms.Button();
            this.descendingSort = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxPanel = new System.Windows.Forms.Panel();
            this.checkBoxPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // candleList
            // 
            this.candleList.AutoArrange = false;
            this.candleList.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.candleList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Scent,
            this.Size,
            this.Color,
            this.Quantity,
            this.Price});
            this.candleList.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.candleList.HideSelection = false;
            this.candleList.Location = new System.Drawing.Point(206, 146);
            this.candleList.Name = "candleList";
            this.candleList.Size = new System.Drawing.Size(384, 247);
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
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(341, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inventory";
            // 
            // addInvButton
            // 
            this.addInvButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.addInvButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.addInvButton.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.addInvButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addInvButton.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addInvButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addInvButton.Location = new System.Drawing.Point(278, 399);
            this.addInvButton.Name = "addInvButton";
            this.addInvButton.Size = new System.Drawing.Size(75, 23);
            this.addInvButton.TabIndex = 3;
            this.addInvButton.Text = "Add";
            this.addInvButton.UseVisualStyleBackColor = false;
            this.addInvButton.Click += new System.EventHandler(this.addInvButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.editButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.editButton.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editButton.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.editButton.Location = new System.Drawing.Point(441, 399);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 4;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(278, 70);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(144, 20);
            this.searchBox.TabIndex = 5;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchButton.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchButton.Location = new System.Drawing.Point(441, 68);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 6;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // scentSort
            // 
            this.scentSort.AutoSize = true;
            this.scentSort.Checked = true;
            this.scentSort.Location = new System.Drawing.Point(3, 12);
            this.scentSort.Name = "scentSort";
            this.scentSort.Size = new System.Drawing.Size(51, 19);
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
            this.sizeSort.Size = new System.Drawing.Size(45, 19);
            this.sizeSort.TabIndex = 8;
            this.sizeSort.Text = "Size";
            this.sizeSort.UseVisualStyleBackColor = true;
            // 
            // colorSort
            // 
            this.colorSort.AutoSize = true;
            this.colorSort.Location = new System.Drawing.Point(110, 12);
            this.colorSort.Name = "colorSort";
            this.colorSort.Size = new System.Drawing.Size(51, 19);
            this.colorSort.TabIndex = 9;
            this.colorSort.Text = "Color";
            this.colorSort.UseVisualStyleBackColor = true;
            // 
            // quantitySort
            // 
            this.quantitySort.AutoSize = true;
            this.quantitySort.Location = new System.Drawing.Point(165, 12);
            this.quantitySort.Name = "quantitySort";
            this.quantitySort.Size = new System.Drawing.Size(68, 19);
            this.quantitySort.TabIndex = 10;
            this.quantitySort.Text = "Quantity";
            this.quantitySort.UseVisualStyleBackColor = true;
            // 
            // priceSort
            // 
            this.priceSort.AutoSize = true;
            this.priceSort.Location = new System.Drawing.Point(235, 12);
            this.priceSort.Name = "priceSort";
            this.priceSort.Size = new System.Drawing.Size(52, 19);
            this.priceSort.TabIndex = 11;
            this.priceSort.Text = "Price";
            this.priceSort.UseVisualStyleBackColor = true;
            // 
            // ascendingSort
            // 
            this.ascendingSort.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ascendingSort.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ascendingSort.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ascendingSort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ascendingSort.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ascendingSort.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ascendingSort.Location = new System.Drawing.Point(619, 129);
            this.ascendingSort.Name = "ascendingSort";
            this.ascendingSort.Size = new System.Drawing.Size(75, 23);
            this.ascendingSort.TabIndex = 12;
            this.ascendingSort.Text = "Ascending";
            this.ascendingSort.UseVisualStyleBackColor = false;
            this.ascendingSort.Click += new System.EventHandler(this.ascendingSort_Click);
            // 
            // descendingSort
            // 
            this.descendingSort.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.descendingSort.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.descendingSort.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.descendingSort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.descendingSort.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descendingSort.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.descendingSort.Location = new System.Drawing.Point(619, 167);
            this.descendingSort.Name = "descendingSort";
            this.descendingSort.Size = new System.Drawing.Size(75, 23);
            this.descendingSort.TabIndex = 13;
            this.descendingSort.Text = "Descending";
            this.descendingSort.UseVisualStyleBackColor = false;
            this.descendingSort.Click += new System.EventHandler(this.descendingSort_Click);
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
            this.checkBoxPanel.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBoxPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.descendingSort);
            this.Controls.Add(this.ascendingSort);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addInvButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.candleList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
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
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.RadioButton scentSort;
        private System.Windows.Forms.RadioButton sizeSort;
        private System.Windows.Forms.RadioButton colorSort;
        private System.Windows.Forms.RadioButton quantitySort;
        private System.Windows.Forms.RadioButton priceSort;
        private System.Windows.Forms.Button ascendingSort;
        private System.Windows.Forms.Button descendingSort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel checkBoxPanel;
        public System.Windows.Forms.ListView candleList;
    }
}

