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
        //List<Candle> candles = new List<Candle>();

        Candle[] candleArray = new Candle[2];

        public CandleInventory()
        {
            //candles = new List<Candle>();
            //add(new Candle("Blueberry", "Small", "Blue", 5, 10.99f));
            //add(new Candle("Creamsicle", "Large", "Orange", 2, 19.99f));

        }

        public void add(Candle candle)
        {
            checkSize();

            if (candleArray[0] == null)
            {
                candleArray[0] = candle;
            }
            else
            {
                for (int i = 0; i < candleArray.Length - 1; i++)
                {
                    if (candleArray[i] != null && candleArray[i + 1] == null)
                    {
                        candleArray[i + 1] = candle;
                        break;
                    }
                }
            }

            //candles.Add(candle);
        }

        public void checkSize()
        {
            

            if (candleArray[candleArray.Length - 1] != null)
            {
                Array.Resize(ref candleArray, candleArray.Length + 1);
                /*
                Candle[] newArray = new Candle[candleArray.Length + 1];
                for (int i = 0; i < candleArray.Length; i++)
                {
                    
                    newArray[i] = candleArray[i];
                }
                candleArray = newArray;
                */
            }
        }

        public void outPut()
        {
            //foreach (Candle c in candles)
            //{
                //Console.WriteLine(c.outPut());
            //}

            for (int i = 0; i < candleArray.Length; i++)
            {
                if (candleArray[i] != null)
                {
                    Console.WriteLine(candleArray[i].outPut());
                }
            }
        }

        //sort by name
        public void nameSort()
        {
            for (int i = candleArray.Length - 1; i >= 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (candleArray[j - 1].getScent().CompareTo(candleArray[j].getScent()) > 0)
                    {
                        var temp = candleArray[j - 1];
                        candleArray[j - 1] = candleArray[j];
                        candleArray[j] = temp;
                    }
                }
            }
            Console.WriteLine("Sort: ");
            outPut();
        }

        public void nameDescSort()
        {
            for (int i = candleArray.Length - 1; i >= 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (candleArray[j - 1].getScent().CompareTo(candleArray[j].getScent()) < 0)
                    {
                        var temp = candleArray[j - 1];
                        candleArray[j - 1] = candleArray[j];
                        candleArray[j] = temp;
                    }
                }
            }
            Console.WriteLine("Sort: ");
            outPut();
        }

        //sort by size
        public void sizeSort()
        {

            for (int i = candleArray.Length - 1; i >= 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    String size1;
                    String size2;

                    size1 = candleArray[j - 1].getSize();
                    size2 = candleArray[j].getSize();

                    int candle1 = 0;
                    int candle2 = 0;

                    switch (size1)
                    {
                        case "Small":
                            candle1 = 1;
                            break;
                        case "Medium":
                            candle1 = 2;
                            break;
                        case "Large":
                            candle1 = 3;
                            break;
                    }

                    switch (size2)
                    {
                        case "Small":
                            candle2 = 1;
                            break;
                        case "Medium":
                            candle2 = 2;
                            break;
                        case "Large":
                            candle2 = 3;
                            break;
                    }


                    if (candle1 > candle2)
                    {
                        var temp = candleArray[j - 1];
                        candleArray[j - 1] = candleArray[j];
                        candleArray[j] = temp;
                    }
                }
            }

            Console.WriteLine("Sort: ");
            //outPut();
        }

        public void sizeDescSort()
        {
            for (int i = candleArray.Length - 1; i >= 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    String size1;
                    String size2;

                    size1 = candleArray[j - 1].getSize();
                    size2 = candleArray[j].getSize();

                    int candle1 = 0;
                    int candle2 = 0;

                    switch (size1)
                    {
                        case "Small":
                            candle1 = 1;
                            break;
                        case "Medium":
                            candle1 = 2;
                            break;
                        case "Large":
                            candle1 = 3;
                            break;
                    }

                    switch (size2)
                    {
                        case "Small":
                            candle2 = 1;
                            break;
                        case "Medium":
                            candle2 = 2;
                            break;
                        case "Large":
                            candle2 = 3;
                            break;
                    }


                    if (candle1 < candle2)
                    {
                        var temp = candleArray[j - 1];
                        candleArray[j - 1] = candleArray[j];
                        candleArray[j] = temp;
                    }
                }
            }

            Console.WriteLine("Sort: ");
            //outPut();
        }

        //sort by color
        public void colorSort()
        {
            for (int i = candleArray.Length - 1; i >= 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (candleArray[j - 1].getColor().CompareTo(candleArray[j].getColor()) > 0)
                    {
                        var temp = candleArray[j - 1];
                        candleArray[j - 1] = candleArray[j];
                        candleArray[j] = temp;
                    }
                }
            }
            Console.WriteLine("Sort: ");
            //outPut();
        }

        public void colorDescSort()
        {
            for (int i = candleArray.Length - 1; i >= 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (candleArray[j - 1].getColor().CompareTo(candleArray[j].getColor()) < 0)
                    {
                        var temp = candleArray[j - 1];
                        candleArray[j - 1] = candleArray[j];
                        candleArray[j] = temp;
                    }
                }
            }
            Console.WriteLine("Sort: ");
            //outPut();
        }
        //sort by quantity
        public void quantitySort()
        {
            for (int i = candleArray.Length - 1; i >= 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (int.Parse(candleArray[j - 1].getQuantity()) > int.Parse(candleArray[j].getQuantity()))
                    {
                        var temp = candleArray[j - 1];
                        candleArray[j - 1] = candleArray[j];
                        candleArray[j] = temp;
                    }
                }
            }
            Console.WriteLine("Sort: ");
            //outPut();
        }

        public void quantityDescSort()
        {
            for (int i = candleArray.Length - 1; i >= 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (int.Parse(candleArray[j - 1].getQuantity()) < int.Parse(candleArray[j].getQuantity()))
                    {
                        var temp = candleArray[j - 1];
                        candleArray[j - 1] = candleArray[j];
                        candleArray[j] = temp;
                    }
                }
            }
            Console.WriteLine("Sort: ");
            //outPut();
        }

        //sort by price
        public void priceSort()
        {
            for (int i = candleArray.Length - 1; i >= 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (float.Parse(candleArray[j - 1].getPrice()) > float.Parse(candleArray[j].getPrice()))
                    {
                        var temp = candleArray[j - 1];
                        candleArray[j - 1] = candleArray[j];
                        candleArray[j] = temp;
                    }
                }
            }
            Console.WriteLine("Sort: ");
            //outPut();
        }

        public void priceDescSort()
        {
            for (int i = candleArray.Length - 1; i >= 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (float.Parse(candleArray[j - 1].getPrice()) < float.Parse(candleArray[j].getPrice()))
                    {
                        var temp = candleArray[j - 1];
                        candleArray[j - 1] = candleArray[j];
                        candleArray[j] = temp;
                    }
                }
            }
            Console.WriteLine("Sort: ");
            //outPut();
        }

        public Candle[] nameSearch(String name)
        {
            Candle[] nameResults = new Candle[candleArray.Length];
            for (int i = 0; i < candleArray.Length; i++)
            {
                if (candleArray[i].getScent().Equals(name))
                {
                    for (int j = 0; j < nameResults.Length; j++)
                    {
                        if (nameResults[j] == null)
                        {
                            nameResults[j] = candleArray[i];
                            break;
                        }
                    }
                }
            }
            return nameResults;
        }

        //get a generic candle from edit page and find the right on in inventory
        public Candle findCandleInInventory(Candle c)
        {
            for (int i = 0; i < candleArray.Length; i++)
            {
                if (candleArray[i].getScent().Equals(c.getScent()))
                {
                    if (candleArray[i].getSize().Equals(c.getSize()))
                    {
                        if (candleArray[i].getColor().Equals(c.getColor()))
                        {
                            if (candleArray[i].getQuantity().Equals(c.getQuantity()))
                            {
                                if (candleArray[i].getPrice().Equals(c.getPrice()))
                                {
                                    Candle cand = candleArray[i];
                                    cand.outPut();
                                    return cand;
                                }
                            }
                        }
                    }
                }
            }

            return null;
        }

        /*
        public List<Candle> candlesOut()
        {
            return candles;
        }
        */

        public Candle[] arrayOut()
        {
            return candleArray;
        }

        public void removeCandle(Candle c)
        {
            Candle[] newCandles = new Candle[candleArray.Length - 1];

            int i = 0;
            int j = 0;
            while (i < candleArray.Length)
            {
                if (candleArray[i].outPut() != findCandleInInventory(c).outPut())
                {
                    newCandles[j] = candleArray[i];
                    j++;
                }

                i++;
            }

            candleArray = newCandles;
        }

    }

}
