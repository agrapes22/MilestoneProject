using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilestoneProject
{
    public class CandleInventory
    {
        List<Candle> candles = new List<Candle>();

        public CandleInventory()
        {
            candles = new List<Candle>();
        }

        public void add(Candle candle)
        {
            candles.Add(candle);
        }

        public void outPut()
        {
            foreach (Candle c in candles)
            {
                Console.WriteLine(c.outPut());
            }
        }
        
        public List<Candle> candlesOut()
        {
            return candles;
        }

    }
}
