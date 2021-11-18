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
                Console.WriteLine("Choose an Option..:\n 1.JSON \n 2.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        InventoryMain inv = new InventoryMain();
                        inv.DisplayData(@"C:\Users\Venu Gopal Reddy\Bridgelabz\c#\.net\ObjectOrientedProgram\ObjectOrientedProgramming\ObjectOrientedProgram\ObjectOrientedProgram\Files\Inventory.json");
                        break;
                    case 2:
                        flag = false;
                        break;
                }
            }
        }
    }
}
