using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Sedan:Cars
    {

        public int Length { get; set; }
        

        public Sedan()
        {
        }

        public Sedan(int id, double regularPrice, string color, decimal speed, int length) : base(id, regularPrice, color, speed)
        {
            this.Length = length;
        }

        public override double GetSalePrice()
        {
            if (Length > 20)
                return base.RegularPrice * 0.95;
            else
                return base.RegularPrice * 0.90;

        }
      

        public virtual void Add()
        {
            base.Add();
            Console.Write("Enter Length:");
            int Length;
            while (!int.TryParse(Console.ReadLine(), out Length))
            {
                Console.WriteLine("Invalid value!Try again.");
                Console.Write("Re-Enter Length:");
            }
            this.Length = Length;

            Console.WriteLine(Length);
        }

        public override string ToString()
        {
            return base.ToString() + $"\t{this.Length}";
        }






    }
}
