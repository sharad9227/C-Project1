using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Laptop Commodity Class  extending Commodity Class 
    class LaptopComm : Commodity
    {
        private String cpuType;

        public string CpuType { get => cpuType; set => cpuType = value; }

        // Overiding parent class method
        public override String Get_basic_information()

        {
            Console.WriteLine("*********************************************Commodity Information********************************************");
            return "\n\tCommodityID : " + this.Id_number + "\n\tCommodityName : " + this.Name + "\n\tCommodityPrice : " + this.Price + "\n\tCommodityBrand : " + this.Brand + "\n\tCommodity Type : " + this.Type + "\n\tCommodity Stock : " + this.Stock + "\n\tLaptopCPUConfig : "+ this.cpuType;

        }

    }

}
