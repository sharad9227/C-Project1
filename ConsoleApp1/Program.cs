using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{



    class Program
    {
        static void Main(string[] args)
        {

            Program app = new Program();
            //setting commodity values  
            Console.WriteLine("enter any key to check next commodity");
            Console.ReadKey();
            Commodity com1 = new Commodity();
            com1.Id_number = 1;
            com1.Name = "Clothes";
            com1.Type = 100010;
            com1.Size = 40;
            com1.Stock = 10;
            com1.Brand = "Levis";
            com1.Price = 40;
            //Method for getting those values 
            Console.WriteLine(com1.Get_basic_information());
            /* User enters the amount of quantity to be sold:: Should be >0   :: Accordingly Remaining Quantity is shown
            if stock less than 3 it will be restocked */
            Console.WriteLine("Do you want to sell this"+" " + com1.Name +" " +"commodity: Enter the quantity you want to sell");
            int quantity= Convert.ToInt32(Console.ReadLine());

            if (quantity>0)
            {
               Console.WriteLine("Updated Stock Quantity, Stock Available Now : " + com1.Sell(quantity));
                if (com1.restockFlag)
                {
                    Console.WriteLine("Stock is Restocked as Quantity of Commodity was low");
                }
            }
            else
                Console.WriteLine("Stock quantity Not Updated, Stock Available Now : " + com1.Stock);




            // Setting laptop values :: laptop
            Console.WriteLine("enter any key to check next commodity");
            Console.ReadKey();

            LaptopComm lap = new LaptopComm();
            lap.Id_number = 2;
            lap.CpuType = "Multi-Core";
            lap.Name = "Laptop";
            lap.Type = 100001;
            lap.Size = 24;
            lap.Stock = 10;
            lap.Brand = "DELL";
            lap.Price = 4000;
            Console.WriteLine(lap.Get_basic_information());
            /* User enters the amount of quantity to be sold:: Should be >0   :: Accordingly Remaining Quantity is shown
         if stock less than 3 it will be restocked */
            Console.WriteLine("Do you want to sell this " + " "+ lap.Name + " " + "commodity: Enter the quantity you want to sell");
            int lapQuantity =Convert.ToInt32( Console.ReadLine());
           
            if (lapQuantity > 0)
            {
                Console.WriteLine("Updated Stock Quantity, Stock Available Now : " + lap.Sell(lapQuantity));
                if (lap.restockFlag)
                {
                    Console.WriteLine("Stock is Restocked as Quantity of Commodity was low");
                }
            }
            else
                Console.WriteLine("Stock quantity Not Updated, Stock Available Now : " + lap.Stock);




            // wine class initialization

            Console.WriteLine("Enter any key to check next commodity");
            Console.ReadKey();
            WineCommodity wine = new WineCommodity();
            wine.Id_number = 3;
            wine.Alcohol_content = 00.20;
            wine.Name = "Wine";
            wine.Type = 100005;
            wine.Size = 1;
            wine.Stock = 20;
            wine.Brand = "SULA";
            wine.Price = 20;
            Console.WriteLine(wine.Get_basic_information());
            /* User enters the amount of quantity to be sold:: Should be >0   :: Accordingly Remaining Quantity is shown
         if stock less than 3 it will be restocked */ 
            Console.WriteLine("Do you want to sell this " +" " + wine.Name + " "+ " commodity: Enter the quantity you want to sell");
            int wineQuantity = Convert.ToInt32(Console.ReadLine());

            if (wineQuantity > 0)
            {
                Console.WriteLine("Updated Stock Quantity,Stock Available Now : " + wine.Sell(wineQuantity));
                if (wine.restockFlag)
                {
                    Console.WriteLine("Stock is Restocked as Quantity of Commodity was low");
                }
            }
            else
                Console.WriteLine("Stock quantity Not Updated,Stock Available Now : " + wine.Stock);


            Console.ReadKey();





        }

    }
    }
