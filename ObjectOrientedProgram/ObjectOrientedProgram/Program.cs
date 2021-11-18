using System;

namespace ObjectOrientedProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Welcome to Object Oriented Programming!!");
                Console.WriteLine("Choose an Option..:\n 1.JSON \n 2.InventoryMangement\n 3.StockMangement\n 4.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        InventoryMain inv = new InventoryMain();
                        inv.DisplayData(@"C:\Users\Venu Gopal Reddy\Bridgelabz\c#\.net\ObjectOrientedProgram\ObjectOrientedProgramming\ObjectOrientedProgram\ObjectOrientedProgram\Files\Inventory.json");
                        break;
                    case 2:
                        InventoryMain inventory = new InventoryMain();
                        inventory.DisplayData(@"C:\Users\Venu Gopal Reddy\Bridgelabz\c#\.net\ObjectOrientedProgram\ObjectOrientedProgramming\ObjectOrientedProgram\ObjectOrientedProgram\Files\InventoryList.json");
                        inventory.DisplayData("Rice");
                        break;
                    case 3:
                        Stock stock = new Stock();
                        stock.DisplayData(@"C:\Users\Venu Gopal Reddy\Bridgelabz\c#\.net\ObjectOrientedProgram\ObjectOrientedProgramming\ObjectOrientedProgram\ObjectOrientedProgram\Files\Stocks.json");
                        break;
                    case 4:
                        flag = false;
                        break;
                }
            }
        }
    }
}
