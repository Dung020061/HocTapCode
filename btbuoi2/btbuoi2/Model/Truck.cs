using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Truck : Cars
    {
        public int Weight { get; set; }
        public Truck(int id, double regularPrice, string color, decimal speed, int Weight) : base(id, regularPrice, color, speed)

        {
            this.Weight = Weight;
        }

        public Truck()
        {
        }

   

      
 
        public override double GetSalePrice()
        {
            if (Weight > 2000)
                return base.RegularPrice * 0.9;
            else
                return base.RegularPrice * 0.8;

        }
        public virtual void Add()
        {
            base.Add();
            Console.Write("Enter Weight:");
            int Weight;
            while (!int.TryParse(Console.ReadLine(), out Weight))
            {
                Console.WriteLine("Invalid value!Try again.");
                Console.Write("Re-Enter Weight:");
            }
            this.Weight = Weight;

            Console.WriteLine(Weight);
        }
        public override string ToString()
        {
            return base.ToString()+$"{this.Weight}";
        }
    }
}
