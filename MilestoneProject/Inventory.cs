using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilestoneProject
{
    public partial class HomePage : Form
    {

        CandleInventory candles = new CandleInventory();

        public HomePage()
        {
            InitializeComponent();

            candles.add(new Candle("Blueberry", "Small", "Blue", 5, 10.99f));
            candles.add(new Candle("Creamsicle", "Large", "Orange", 2, 19.99f));

            Candle[] candlesArr = candles.arrayOut();

            for (int i = 0; i < candlesArr.Length; i++)
            {
                if (candlesArr[i] != null)
                {
                    candleList.Items.Add(new ListViewItem(new[] {candlesArr[i].getScent(), candlesArr[i].getSize(),
                    candlesArr[i].getColor(), candlesArr[i].getQuantity().ToString(), candlesArr[i].getPrice().ToString() }));
                }
            }

            
        }

        private void addInvButton_Click(object sender, EventArgs e)
        {
            Form createPage = new CreatePage(candles);
            createPage.Show();

            createPage.FormClosing += new FormClosingEventHandler(createPage_FormClosing);
        }

        void createPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            candleList.Items.Clear();
            
            candles.outPut();

            Candle[] candlesArr = candles.arrayOut();
            /*
            foreach (Candle c in candlesArr)
            {
                candleList.Items.Add(new ListViewItem(new[] {c.getScent(), c.getSize(),
                    c.getColor(), c.getQuantity().ToString(), c.getPrice().ToString() }));
            }
            */
            for (int i = 0; i < candlesArr.Length; i++)
            {
                if (candlesArr[i] != null)
                {
                    candleList.Items.Add(new ListViewItem(new[] {candlesArr[i].getScent(), candlesArr[i].getSize(),
                    candlesArr[i].getColor(), candlesArr[i].getQuantity().ToString(), candlesArr[i].getPrice().ToString() }));
                }
            }


        }

        void editPage_FormClosingEdit(object sender, FormClosingEventArgs e)
        {
            candleList.Items.Clear();

            Candle[] candlesArr = candles.arrayOut();

            for (int i = 0; i < candlesArr.Length; i++)
            {
                if (candlesArr[i] != null)
                {
                    candleList.Items.Add(new ListViewItem(new[] {candlesArr[i].getScent(), candlesArr[i].getSize(),
                    candlesArr[i].getColor(), candlesArr[i].getQuantity().ToString(), candlesArr[i].getPrice().ToString() }));
                }
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            String output = "";

            for (int i = 0; i < candles.nameSearch(searchBox.Text).Length; i++)
            {
                if (candles.nameSearch(searchBox.Text)[i] != null)
                {
                    output += candles.nameSearch(searchBox.Text)[i].getScent();
                }
            }

            candleList.Items.Clear();

            Candle[] candlesArr = candles.nameSearch(searchBox.Text);

            for (int i = 0; i < candlesArr.Length; i++)
            {
                if (candlesArr[i] != null)
                {
                    candleList.Items.Add(new ListViewItem(new[] {candlesArr[i].getScent(), candlesArr[i].getSize(),
                    candlesArr[i].getColor(), candlesArr[i].getQuantity().ToString(), candlesArr[i].getPrice().ToString() }));
                }
            }

            Console.WriteLine("Search " + output);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            ListViewItem item = candleList.SelectedItems[0];

            Candle c = new Candle();

            c.setScent(item.Text);
            c.setSize(item.SubItems[1].Text);
            c.setColor(item.SubItems[2].Text);
            c.setQuantity(int.Parse(item.SubItems[3].Text));
            c.setPrice(float.Parse(item.SubItems[4].Text));

            Console.WriteLine(c.outPut());

            Form editPage = new EditPage(c, candles);

            editPage.Show();

            editPage.FormClosing += new FormClosingEventHandler(editPage_FormClosingEdit);
        }

        private void ascendingSort_Click(object sender, EventArgs e)
        {
            if (scentSort.Checked)
            {
                candles.nameSort();

                Candle[] candlesArr = candles.arrayOut();

                candleList.Items.Clear();

            
                for (int i = 0; i < candlesArr.Length; i++)
                {
                    if (candlesArr[i] != null)
                    {
                        candleList.Items.Add(new ListViewItem(new[] {candlesArr[i].getScent(), candlesArr[i].getSize(),
                        candlesArr[i].getColor(), candlesArr[i].getQuantity().ToString(), candlesArr[i].getPrice().ToString() }));
                        Console.WriteLine("Sorted Asc: " + candlesArr[i].outPut());
                    }
                }
            }
            if (sizeSort.Checked)
            {
                candles.sizeSort();

                Candle[] candlesArr = candles.arrayOut();

                candleList.Items.Clear();

                for (int i = 0; i < candlesArr.Length; i++)
                {
                    if (candlesArr[i] != null)
                    {
                        candleList.Items.Add(new ListViewItem(new[] {candlesArr[i].getScent(), candlesArr[i].getSize(),
                        candlesArr[i].getColor(), candlesArr[i].getQuantity().ToString(), candlesArr[i].getPrice().ToString() }));
                    }
                }
                
            }
            if (colorSort.Checked)
            {
                candles.colorSort();

                candleList.Items.Clear();

                Candle[] candlesArr = candles.arrayOut();

                for (int i = 0; i < candlesArr.Length; i++)
                {
                    if (candlesArr[i] != null)
                    {
                        candleList.Items.Add(new ListViewItem(new[] {candlesArr[i].getScent(), candlesArr[i].getSize(),
                    candlesArr[i].getColor(), candlesArr[i].getQuantity().ToString(), candlesArr[i].getPrice().ToString() }));
                    }
                }

                candles.outPut();
            }
            if (priceSort.Checked)
            {
                candleList.Items.Clear();

                candles.priceSort();

                Candle[] candlesArr = candles.arrayOut();

                for (int i = 0; i < candlesArr.Length; i++)
                {
                    if (candlesArr[i] != null)
                    {
                        candleList.Items.Add(new ListViewItem(new[] {candlesArr[i].getScent(), candlesArr[i].getSize(),
                    candlesArr[i].getColor(), candlesArr[i].getQuantity().ToString(), candlesArr[i].getPrice().ToString() }));
                    }
                }

                candles.outPut();
            }
            if (quantitySort.Checked)
            {
                candleList.Items.Clear();

                candles.quantitySort();

                Candle[] candlesArr = candles.arrayOut();

                for (int i = 0; i < candlesArr.Length; i++)
                {
                    if (candlesArr[i] != null)
                    {
                        candleList.Items.Add(new ListViewItem(new[] {candlesArr[i].getScent(), candlesArr[i].getSize(),
                    candlesArr[i].getColor(), candlesArr[i].getQuantity().ToString(), candlesArr[i].getPrice().ToString() }));
                    }
                }

                candles.outPut();
            }
        }

        private void descendingSort_Click(object sender, EventArgs e)
        {
            if (scentSort.Checked)
            {
                candles.nameDescSort();

                Candle[] candlesArr = candles.arrayOut();

                

                candleList.Items.Clear();

                for (int i = 0; i < candlesArr.Length; i++)
                {
                    if (candlesArr[i] != null)
                    {
                        candleList.Items.Add(new ListViewItem(new[] {candlesArr[i].getScent(), candlesArr[i].getSize(),
                        candlesArr[i].getColor(), candlesArr[i].getQuantity().ToString(), candlesArr[i].getPrice().ToString() }));
                        Console.WriteLine("Sorted Desc: " + candlesArr[i].outPut());
                    }
                }

                candleList.EndUpdate();

            }
            if (sizeSort.Checked)
            {
                candles.sizeDescSort();

                Candle[] candlesArr = candles.arrayOut();

                candleList.Items.Clear();

                for (int i = 0; i < candlesArr.Length; i++)
                {
                    if (candlesArr[i] != null)
                    {
                        candleList.Items.Add(new ListViewItem(new[] {candlesArr[i].getScent(), candlesArr[i].getSize(),
                        candlesArr[i].getColor(), candlesArr[i].getQuantity().ToString(), candlesArr[i].getPrice().ToString() }));
                    }
                }

            }
            if (colorSort.Checked)
            {
                candles.colorDescSort();

                candleList.Items.Clear();

                Candle[] candlesArr = candles.arrayOut();

                for (int i = 0; i < candlesArr.Length; i++)
                {
                    if (candlesArr[i] != null)
                    {
                        candleList.Items.Add(new ListViewItem(new[] {candlesArr[i].getScent(), candlesArr[i].getSize(),
                    candlesArr[i].getColor(), candlesArr[i].getQuantity().ToString(), candlesArr[i].getPrice().ToString() }));
                    }
                }

                candles.outPut();
            }
            if (priceSort.Checked)
            {
                candleList.Items.Clear();

                candles.priceDescSort();

                Candle[] candlesArr = candles.arrayOut();

                for (int i = 0; i < candlesArr.Length; i++)
                {
                    if (candlesArr[i] != null)
                    {
                        candleList.Items.Add(new ListViewItem(new[] {candlesArr[i].getScent(), candlesArr[i].getSize(),
                    candlesArr[i].getColor(), candlesArr[i].getQuantity().ToString(), candlesArr[i].getPrice().ToString() }));
                    }
                }

                candles.outPut();
            }
            if (quantitySort.Checked)
            {
                candleList.Items.Clear();

                candles.quantityDescSort();

                Candle[] candlesArr = candles.arrayOut();

                for (int i = 0; i < candlesArr.Length; i++)
                {
                    if (candlesArr[i] != null)
                    {
                        candleList.Items.Add(new ListViewItem(new[] {candlesArr[i].getScent(), candlesArr[i].getSize(),
                    candlesArr[i].getColor(), candlesArr[i].getQuantity().ToString(), candlesArr[i].getPrice().ToString() }));
                    }
                }

                candles.outPut();
            }
        }
    }
}
