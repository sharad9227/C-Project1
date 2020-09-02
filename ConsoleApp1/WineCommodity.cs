using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Wine Commodity Class  extending Commodity Class 
    class WineCommodity : Commodity
    {
        private double alcohol_content;
        public double Alcohol_content { get => alcohol_content; set => alcohol_content = value; }

        // Overiding parent class method 

        public override String Get_basic_information()

        {
            Console.WriteLine("*********************************************Commodity Information********************************************");
            return "\n\tCommodityID : " + this.Id_number + "\n\tCommodityName : " + this.Name + "\n\tCommodityPrice : " + this.Price + "\n\tCommodityBrand : " + this.Brand + "\n\tCommodity Type : " + this.Type + "\n\tCommodity Stock : " + this.Stock + "\n\tWineAlcoholContent : " + this.alcohol_content;

        }
    }
}
