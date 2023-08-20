using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic1_winfromdesign
{
    internal class FileOperation
    {
        //internal static List<Employee> LoadDataFromFile(string filePath)
        //{
        //    List<Employee> data = new List<Employee>();
        //    try
        //    {
        //        StreamReader s = new StreamReader(filePath);


        //       string result= s.ReadLine();
        //        while (result != null)
        //        {
        //            string[] arr = result.Split(";");
        //            var emp = new Employee()
        //            {
        //                id = int.Parse(arr[0]),
        //                name = arr[1],
        //                Dob = DateTime.Parse(arr[2]),

        //                Gender = bool.Parse(arr[3]),
        //                City = arr[4],

        //            };
        //            data.Add(emp);
        //            result = s.ReadLine();
        //        }

        //        return data;
        //    }catch(Exception ex)
        //    {
        //        throw new Exception(ex.Message);
            
        //    }
        //}

        //internal static bool SavetoFile(List<Employee> employeees, string filePath)
        //{
        //    try
        //    {
        //        ///khoi tao doi tuong de  ghi file
        //        ///
        //        StreamWriter s = new StreamWriter(filePath,false);
        //        // tổ chức định dạng dữ liệu cần ghi
        //        foreach (Employee e in employeees)
        //        {
        //            string data = $"{e.id};{e.name};{e.Dob.ToString("MM-dd-yyyy")};{e.Gender};{e.City}";
        //            s.WriteLine(data);

        //        }
        //       s.Close();
        //        return true;
        //    }catch(Exception ex)
        //    {

        //        throw new Exception(ex.Message);
        //    }

        //}
    }
}
