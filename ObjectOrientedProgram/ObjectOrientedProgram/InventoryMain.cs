using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ObjectOrientedProgram
{
    class InventoryMain
    {
        List<InventoryModel> RiceList;
        List<InventoryModel> WheatList;
        List<InventoryModel> PulsesList;
        public void ReadData(string filepath)
        {
            try
            {
                using (StreamReader r = new StreamReader(filepath))
                {
                    var json = r.ReadToEnd();
                    InventoryFactory item = JsonConvert.DeserializeObject<InventoryFactory>(json);
                    RiceList = item.Rice;
                    WheatList = item.Wheat;
                    PulsesList = item.Pulses;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void DisplayData(string state)
        {
            if (state == "Rice")
            {
                Console.WriteLine("Name\tWeight\tPrice");
                foreach (var item in RiceList)
                {
                    Console.WriteLine("{0}" + "\t" + "{1}" + "\t" + "{2}", item.Name, item.Weight, item.Price);
                }
            }
            if (state == "Wheat")
            {
                Console.WriteLine("Name\tWeight\tPrice");
                foreach (var item in WheatList)
                {
                    Console.WriteLine("{0}" + "\t" + "{1}" + "\t" + "{2}", item.Name, item.Weight, item.Price);
                }
            }
            if (state == "Pulses")
            {
                Console.WriteLine("Name\tWeight\tPrice");
                foreach (var item in PulsesList)
                {
                    Console.WriteLine("{0}" + "\t" + "{1}" + "\t" + "{2}", item.Name, item.Weight, item.Price);
                }
            }
        }
    }
}
