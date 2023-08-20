using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btbuoi2.Utill
{
    internal class Validate
    {
        public static string GetStringInput(string mess)
        {
            string input = null;
            //string.IsNullOrEmpty để kiểm tra xem chuỗi nhập vào có rỗng hoặc null hay không
            while (string.IsNullOrEmpty(input))
            {
                Console.Write(mess);
                input = Console.ReadLine().Trim();
                if (!string.IsNullOrEmpty(input))
                {
                    return input;
                }
                Console.WriteLine("The input string is empty or null, please enter again: ");
            }

            return input;
        }
        public static int GetIntInput(string mess)
        {
            while (true)
            {
                Console.Write(mess);
                string input = Console.ReadLine();
                //int.TryParse để kiểm tra xem chuỗi nhập vào có thể chuyển đổi sang một số nguyên hay không
                if (int.TryParse(input, out int result) && !string.IsNullOrEmpty(input))
                {

                    return result;
                }
                Console.WriteLine("Invalid input, please enter again: ");
            }
        }
        public static int GetIntInputOption(string mess, int min, int max)
        {
            while (true)
            {
                Console.Write(mess);
                string input = Console.ReadLine();
                //int.TryParse để kiểm tra xem chuỗi nhập vào có thể chuyển đổi sang một số nguyên hay không
                if (int.TryParse(input, out int result) && !string.IsNullOrEmpty(input) && result >= min && result <= max)
                {

                    return result;
                }
                Console.WriteLine("Invalid number, please re-enter: ");
            }
        }
    }
}
