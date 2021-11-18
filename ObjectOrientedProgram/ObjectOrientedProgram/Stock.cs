using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ObjectOrientedProgram
{
    class Stock
    {
        public void DisplayData(string filepath)
        {
            try
            {
                using (StreamReader r = new StreamReader(filepath))
                {
                    var json = r.ReadToEnd();
                    var items = JsonConvert.DeserializeObject<List<StockPortfolio>>(json);
                    Console.WriteLine("StockName\tNoOfStock\tPricePerStock\tTotal");
                    foreach (var item in items)
                    {
                        Console.WriteLine("{0}" + "\t\t" + "{1}" + "\t\t" + "{2}" + "\t\t" + "{3}", item.Stock, item.NoOfStocks, item.PricePerStock ,item.NoOfStocks * item.PricePerStock);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
