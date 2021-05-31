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
    public partial class HomePage : Form
    {

        CandleInventory candles = new CandleInventory();

        public HomePage()
        {
            InitializeComponent();
        }

        private void addInvButton_Click(object sender, EventArgs e)
        {
            Form editPage = new EditPage(candles);
            editPage.Show();

            editPage.FormClosing += new FormClosingEventHandler(editPage_FormClosing);
        }

        void editPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            candleList.Items.Clear();

            //candleList.Items.Add(new ListViewItem(new[] {"Cream","Small","White","5","14.99"}));

            Candle c1 = new Candle("Cream", "Small", "White", 5, 14.99f);

            candles.add(c1);
            
            candles.outPut();

            foreach (Candle c in candles.candlesOut())
            {
                candleList.Items.Add(new ListViewItem(new[] {c.getScent(), c.getSize(),
                    c.getColor(), c.getQuantity().ToString(), c.getPrice().ToString() }));
            }


        }
    }
}
