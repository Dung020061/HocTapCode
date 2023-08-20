using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Ford : Cars

    {
        public int Year { get; set; }

        public int ManufacturerDiscount { get; set; }
        public Ford(int id, double regularPrice, string color, decimal speed,int year,int ManufacturerDiscount) : base(id, regularPrice, color, speed)
            
        {
            this.Year = year;
            this.ManufacturerDiscount = ManufacturerDiscount;
        }

        public Ford()
        {
        }


        public override double GetSalePrice()
        {
            return base.RegularPrice - (base.RegularPrice * (ManufacturerDiscount * 0.01));

        }
        public virtual void Add()
        {
            base.Add();
            Console.Write("Enter Year:");
            int Year;
            while (!int.TryParse(Console.ReadLine(), out Year))
            {
                Console.WriteLine("Invalid value!Try again.");
                Console.Write("Re-Enter Year:");
            }
            this.Year = Year;
            Console.WriteLine(Year);

            Console.Write("Enter ManufacturerDiscount:");
            int ManufacturerDiscount;
            while (!int.TryParse(Console.ReadLine(), out ManufacturerDiscount))
            {
                Console.WriteLine("Invalid value!Try again.");
                Console.Write("Re-Enter ManufacturerDiscount:");
            }
            this.ManufacturerDiscount = ManufacturerDiscount;
            Console.WriteLine(ManufacturerDiscount);
        }
        public override string ToString()
        {
            return base.ToString()+$" {this.Year}\t {this.ManufacturerDiscount}" ;
        }

    }
}
