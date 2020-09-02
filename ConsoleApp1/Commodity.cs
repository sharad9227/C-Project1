using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /* Console Programme Question 1*/
    
    /* Class for Commodity*/

    class Commodity
    {
        private int id_number;
        private String name;
        private int type;    
        private String brand;
        private double price;
        private int size;
        private int stock;
        public bool restockFlag = false;

        // Encapsulation using Getters and Setters
        public int Id_number { get => id_number; set => id_number = value; }
        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public int Size { get => size; set => size = value; }
        public int Stock { get => stock; set => stock = value; }
      
        public string Brand { get => brand; set => brand = value; }
        public int Type { get => type; set => type = value; }
      
        //Constructor Initialisation :: setting values for pricate members
        public Commodity()
        {
            this.id_number = Id_number;
            this.name = Name;
            this.price = Price;
            this.stock = Stock;
            this.type = Type;
            this.brand = Brand;
            this.size = Size;

        }

       // Method for getting basic information
        public virtual String Get_basic_information()

        {
            Console.WriteLine("*********************************************Commodity Information********************************************");
            return "\n\tCommodityID : " + this.id_number + "\n\tCommodityName : " + this.name + "\n\tCommodityPrice : " + this.price + "\n\tCommodityBrand : " + this.brand + "\n\tCommodity Type : " + this.type + "\n\tCommodity Stock : " + this.stock;

        }

    
        

       /* Method for restocking of commodity :: Adding a buffer amount of 10 to the existing stock
       if the quantity of commodity goes below 3 (assumption that 3 is a low quantity and 
       needs to be restocked)          */

        public int Restock()
        {
            this.Stock = this.Stock + 10;
            this.restockFlag = true;
            return this.Stock;
        }

        // Method For Selling the commodity :: Takes input quantity from user on how much to be sold and calls restock on logic explained 
        public int Sell(int quantity)
        {

            this.Stock = this.Stock - quantity;
            if (this.Stock < 3)
            {
              this.Stock =  Restock();
            }

            return this.Stock;
        }



       
        
    }
}
