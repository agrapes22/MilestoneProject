using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilestoneProject
{
    public partial class CreatePage : Form
    {
        CandleInventory candles;

        public CreatePage(CandleInventory candles)
        {
            this.candles = candles;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePage));
            this.okEditButton = new System.Windows.Forms.Button();
            this.cancelEditButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.scentBox = new System.Windows.Forms.TextBox();
            this.colorBox = new System.Windows.Forms.TextBox();
            this.sizeBox = new System.Windows.Forms.ComboBox();
            this.quantityBox = new System.Windows.Forms.NumericUpDown();
            this.priceBox = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.quantityBox)).BeginInit();
            this.SuspendLayout();
            // 
            // okEditButton
            // 
            this.okEditButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.okEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.okEditButton.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okEditButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.okEditButton.Location = new System.Drawing.Point(203, 309);
            this.okEditButton.Name = "okEditButton";
            this.okEditButton.Size = new System.Drawing.Size(75, 23);
            this.okEditButton.TabIndex = 0;
            this.okEditButton.Text = "OK";
            this.okEditButton.UseVisualStyleBackColor = false;
            this.okEditButton.Click += new System.EventHandler(this.okCreateButton_Click);
            // 
            // cancelEditButton
            // 
            this.cancelEditButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cancelEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelEditButton.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelEditButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelEditButton.Location = new System.Drawing.Point(388, 309);
            this.cancelEditButton.Name = "cancelEditButton";
            this.cancelEditButton.Size = new System.Drawing.Size(75, 23);
            this.cancelEditButton.TabIndex = 1;
            this.cancelEditButton.Text = "Cancel";
            this.cancelEditButton.UseVisualStyleBackColor = false;
            this.cancelEditButton.Click += new System.EventHandler(this.cancelEditButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Scent";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(117, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(409, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(409, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Price";
            // 
            // scentBox
            // 
            this.scentBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.scentBox.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scentBox.Location = new System.Drawing.Point(191, 73);
            this.scentBox.Name = "scentBox";
            this.scentBox.Size = new System.Drawing.Size(100, 20);
            this.scentBox.TabIndex = 7;
            // 
            // colorBox
            // 
            this.colorBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.colorBox.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorBox.Location = new System.Drawing.Point(191, 227);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(100, 20);
            this.colorBox.TabIndex = 8;
            // 
            // sizeBox
            // 
            this.sizeBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sizeBox.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeBox.FormattingEnabled = true;
            this.sizeBox.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large"});
            this.sizeBox.Location = new System.Drawing.Point(191, 144);
            this.sizeBox.Name = "sizeBox";
            this.sizeBox.Size = new System.Drawing.Size(100, 23);
            this.sizeBox.TabIndex = 10;
            // 
            // quantityBox
            // 
            this.quantityBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.quantityBox.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityBox.Location = new System.Drawing.Point(479, 87);
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.Size = new System.Drawing.Size(49, 20);
            this.quantityBox.TabIndex = 11;
            // 
            // priceBox
            // 
            this.priceBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.priceBox.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.priceBox.Location = new System.Drawing.Point(479, 196);
            this.priceBox.Mask = "00.00";
            this.priceBox.Name = "priceBox";
            this.priceBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.priceBox.Size = new System.Drawing.Size(69, 20);
            this.priceBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(270, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Add Candle";
            // 
            // CreatePage
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(671, 420);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.quantityBox);
            this.Controls.Add(this.sizeBox);
            this.Controls.Add(this.colorBox);
            this.Controls.Add(this.scentBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelEditButton);
            this.Controls.Add(this.okEditButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CreatePage";
            this.Text = "Add New Candle";
            ((System.ComponentModel.ISupportInitialize)(this.quantityBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void okCreateButton_Click(object sender, EventArgs e)
        {
            String scent = scentBox.Text; //blueberry
            String size = sizeBox.Text; //large
            String color = colorBox.Text;
            int quantity = (int)quantityBox.Value;
            float price = float.Parse(priceBox.Text);

            bool exists = false;

            Candle[] cs = candles.arrayOut();

            for (int i = 0; i < cs.Length; i++)
            {
                if (cs[i].getScent().Equals(scent))
                {
                    if (cs[i].getSize().Equals(size))
                    {
                        //candle already exists don't add it
                        exists = true;
                    }
                }
            }

            //Candle candle = new Candle(scent, size, color, quantity, price);

            if (exists == false)
            {
                candles.add(new Candle(scent, size, color, quantity, price));
            }

            //candles.outPut();

            Close();
        }

        private void cancelEditButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
