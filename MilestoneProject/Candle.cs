using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilestoneProject
{
    public class Candle
    {
        String scent;
        String size;
        String color;
        int quantity;
        float price;

        public CandleInventory candles = new CandleInventory();

        public Candle()
        {

        }

        public Candle(String scent, String size, String color, int quantity, float price)
        {
            this.scent = scent;
            this.size = size;
            this.color = color;
            this.quantity = quantity;
            this.price = price;

            candles.add(this);
        }

        public String outPut()
        {
            String o = "Candle: " + scent + " " + size + " " + color + " " + quantity + " " + price;

            return o;
        }


        public String getScent()
        {
            return scent;
        }

        public String getSize()
        {
            return size;
        }

        public String getColor()
        {
            return color;
        }

        public String getQuantity()
        {
            return quantity.ToString();
        }

        public String getPrice()
        {
            return price.ToString();
        }

    }
}
