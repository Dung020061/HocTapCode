using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Cars
    {
        public Cars(int id, double regularPrice, string color, decimal speed)
        {
            this.id = id;
            RegularPrice = regularPrice;
            Color = color;
            Speed = speed;
        }

        public Cars()
        {
        }

        public int id { get; set; }
        public double RegularPrice { get; set; }
        public string Color { get; set; }

        public decimal Speed { get; set; }

        public virtual double GetSalePrice()
        {
            return this.RegularPrice;
        }

        public override string ToString()
        {
            return $"{this.id}\t{this.RegularPrice}\t{this.Color}\t{this.Speed}";
        }
        public void Add()
        {
            Console.Write("Enter carid:");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Invalid value!Try again.");
                Console.Write("Re-Enter carid:");
            }
            this.id = id;

            Console.WriteLine(id);

            Console.Write("RegularPrice: ");

            RegularPrice = double.Parse(Console.ReadLine());


            Console.Write("color: ");
            Color = Console.ReadLine();

            Console.Write("speed: ");
            Speed = decimal.Parse(Console.ReadLine());
        }
    }
}