using btbuoi2.Utill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btbuoi2.Manager
{
    internal class Menu
    {

        public static int GetOptionMenuAddAndGet()
        {
            Console.WriteLine("Select a category:");
            Console.WriteLine("1. english");
            Console.WriteLine("2. math");
        
            int option = Validate.GetIntInputOption("Choose an option: ", 1, 2);

            return option;
        }

        /// <summary>
        /// 1. Salaried Employee 2. Hourly Employee 3. Exit
        /// </summary>
        /// <returns></returns>
        public static int GetOptionMenuAddEmployee()
        {
            Console.WriteLine("1. Xem danh sach xe");
            Console.WriteLine("2. nhap xe");
            Console.WriteLine("3.update xe");
            Console.WriteLine("4. xoa vehicle");
            Console.WriteLine("5. thoat");
            Console.Write("Select an option: ");
            int option = Validate.GetIntInputOption("Choose an option: ", 1, 5);

            return option;
        }

        /// <summary>
        /// 1. Salaried Employee 2. Hourly Employee 3. Exit
        /// </summary>
        /// <returns></returns>
        public static int GetOptionMenuGetCountEmployee()
        {
            Console.WriteLine("Select a category:");
            Console.WriteLine("1. Sedan");
            Console.WriteLine("2. Truck");
            Console.WriteLine("3. Ford");
            Console.WriteLine("4. Exit");
            int option = Validate.GetIntInputOption("Choose an option: ", 1, 3);

            return option;
        }

        /// <summary>
        /// 1. Salaried Employee   2. Hourly Employee   3. Exit
        /// </summary>
        /// <returns></returns>
        public static int GetOptionMenuGetEmployee()
        {
            Console.WriteLine("Get Employee List");
            Console.WriteLine("1. Salaried Employee");
            Console.WriteLine("2. Hourly Employee");
            Console.WriteLine("3. Exit");
            int option = Validate.GetIntInputOption("Choose an option: ", 1, 3);

            return option;
        }
        /// <summary>
        /// 1. Input data from the keyboard    2. Display employees   3. Classify employees   4. Employee Search   5. Report
        /// </summary>
        /// <returns></returns>
        public static int GetOptionMenu()
        {
            Console.Clear();
            Console.WriteLine("Munu Function");
            Console.WriteLine("0. Input data auto");
            Console.WriteLine("1. Input data from the keyboard");
            Console.WriteLine("2. Display employees");
            Console.WriteLine("3. Classify employees");
            Console.WriteLine("4. Employee Search");
            Console.WriteLine("5. Report");
            int option = Validate.GetIntInputOption("Choose an option: ", 0, 5);

            return option;
        }

        /// <summary>
        /// 1. Search by department name   2. Search by employee name  3. Exit
        /// </summary>
        /// <returns></returns>
        public static int GetOptionMenuSearch()
        {
            Console.WriteLine("1. Search by department name");
            Console.WriteLine("2. Search by employee name");
            Console.WriteLine("3. Exit");
            int option = Validate.GetIntInputOption("Choose an option: ", 1, 3);

            return option;
        }
    }
}
