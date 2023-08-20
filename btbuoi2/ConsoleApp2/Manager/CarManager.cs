using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using btbuoi2.Manager;
using ConsoleApp2;
using ConsoleApp2.Models;

namespace ConsoleApp2.Manager
{
    internal class CarManager : ICarManager
    {


        public void InputData()
        {
            bool checkCha = true;
            do
            {
                switch (Menu.GetOptionMenuAddAndGet())
                {
                    case 1:
                        //Chon the loai xe them vao 1 la sedan
                        add1();
                        break;
                    case 2:
                        //Chon the loai xe them vao 2 la Truck
                        add2();
                        break;
                 
                    default:
                        Console.WriteLine("Invalid category choice.");
                        break;
                }

              

            } while (checkCha);


        }
        public void UpdateData()
        {
            Console.WriteLine("Select a category:");
            Console.WriteLine("1. Sedan");
            Console.WriteLine("2. Truck");
            Console.WriteLine("3. Ford");
            int categoryChoice = Convert.ToInt32(Console.ReadLine());

            switch (categoryChoice)
            {
                case 1:
                    Console.WriteLine("Enter the ID of the Sedan to update:");
                    int sedanId = int.Parse(Console.ReadLine());
                    Update1(sedanId);
                    break;
                case 2:
                    Console.WriteLine("Enter the ID of the Truck to update:");
                    int truckId = int.Parse(Console.ReadLine());
                    Update2(truckId);
                    break;
              
                default:
                    Console.WriteLine("Invalid category choice.");
                    break;
            }

        }

        public void Display()
        {
            Console.WriteLine("Select a category:");
            Console.WriteLine("1. English");
            Console.WriteLine("2. Math");
           
            int categoryChoice = Convert.ToInt32(Console.ReadLine());

            switch (categoryChoice)
            {
                case 1:
                    display1();
                    break;
                case 2:
                    display2();
                    break;
             
                default:
                    Console.WriteLine("Invalid category choice.");
                    break;
            }
        }

        public void DeleteData()
        {
            Console.WriteLine("Select a category:");
            Console.WriteLine("1. English");
            Console.WriteLine("2. Math");
      
            int categoryChoice = Convert.ToInt32(Console.ReadLine());

            switch (categoryChoice)
            {
                case 1:
                    Console.WriteLine("Enter the ID of the Sedan to update:");
                    int sedanId = int.Parse(Console.ReadLine());
                    Delete1(sedanId);
                    break;
                case 2:
                    Console.WriteLine("Enter the ID of the Truck to update:");
                    int truckId = int.Parse(Console.ReadLine());
                    Delete2(truckId);
                    break;

                default:
                    Console.WriteLine("Invalid category choice.");
                    break;
            }
        }

        public void SaveFile()
        {
            Console.WriteLine("Select a category:");
            Console.WriteLine("1. English");
            Console.WriteLine("2. MathCourses");

            string contentToSave = "";
            int categoryChoice = Convert.ToInt32(Console.ReadLine());

            switch (categoryChoice)
            {
                case 1:
                    using (var db = new btBuoi3Context())
                    {
                        contentToSave = FormatListContent1(db.EnglishCourses.ToList());
                    }
                    break;
                case 2:
                    using (var db = new btBuoi3Context())
                    {
                        contentToSave = FormatListContent2(db.MathCourses.ToList());
                    }
                    break;

                default:
                    Console.WriteLine("Invalid category choice.");
                    break;
            }

            if (!string.IsNullOrEmpty(contentToSave)) // Check if the content is not empty
            {
                Console.Write("Enter the path of the destination text file: ");
                string destinationFilePath = Console.ReadLine();

                if (!string.IsNullOrEmpty(destinationFilePath)) // Check if the destination file path is not empty
                {
                    if (!contentToSave.Equals("")) // Check if the content to save is not empty
                    {
                        if (SaveTextToFile(contentToSave, destinationFilePath))
                        {
                            Console.WriteLine("Text content successfully saved to the file!");
                        }
                        else
                        {
                            Console.WriteLine("An error occurred while saving the file.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Content to save is empty. File not saved.");
                    }
                }
                else
                {
                    Console.WriteLine("Destination file path is empty. File not saved.");
                }
            }
            else
            {
                Console.WriteLine("The selected list is empty. Nothing to save.");
            }
        }
        static bool SaveTextToFile(string content, string filePath)
        {
            try
            {
                File.WriteAllText(filePath, content);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public void add1()
        {
            using (var db = new btBuoi3Context())
            {
                // Fetch the parent Course (assuming you have a Course with ID = 1)
                var parentCourse = db.Courses.FirstOrDefault(c => c.Id == 3);

                if (parentCourse != null)
                {
                    Console.WriteLine("EnglishInstructor");
                    Console.WriteLine("EnglishTopic");
                    var newEnglishCourse = new EnglishCourse
                    {
                         
                    EnglishInstructor = Console.ReadLine(),

                        EnglishTopic = Console.ReadLine(),
                        CourseId = parentCourse.Id, // Set the CourseId to the Id of the parentCourse
                    };

                    db.EnglishCourses.Add(newEnglishCourse);
                    if (db.SaveChanges() > 0)
                    {
                        Console.WriteLine("Add success");
                    }
                }
                
            }

        }
        public void add2()
        {
            using (var db = new btBuoi3Context())
            {
                // Fetch the parent Course (assuming you have a Course with ID = 1)
                var parentCourse = db.Courses.FirstOrDefault(c => c.Id == 1);

                if (parentCourse != null)
                {
                    Console.WriteLine("MathInstructor:");
                    Console.WriteLine("MathTopic:");
                    var newEnglishCourse = new MathCourse
                    {

                        MathInstructor = Console.ReadLine(),

                        MathTopic = Console.ReadLine(),
                        CoursesId = parentCourse.Id, // Set the CourseId to the Id of the parentCourse
                    };

                    db.MathCourses.Add(newEnglishCourse);
                    if (db.SaveChanges() > 0)
                    {
                        Console.WriteLine("Add success");
                    }
                }

            }

        }

        public void Update1(int id)
        {
            using (var db = new btBuoi3Context())
            {
                var englishCourseToUpdate = db.EnglishCourses.FirstOrDefault(ec => ec.EnglishCoursesid == id);

                if (englishCourseToUpdate != null)
                {
                    Console.WriteLine("New EnglishInstructor:");
                    var newMathInstructor = Console.ReadLine();

                    Console.WriteLine("New EnglishTopic:");
                    var newMathTopic = Console.ReadLine();

                    // Update the properties of the EnglishCourse
                    englishCourseToUpdate.EnglishInstructor = newMathInstructor;
                    englishCourseToUpdate.EnglishTopic = newMathTopic;

                    db.SaveChanges();

                    Console.WriteLine("Update successful");
                }
                else
                {
                    Console.WriteLine("EnglishCourse with the provided ID not found");
                }
            }
        }
        public void Update2(int id)
        {
            using (var db = new btBuoi3Context())
            {
                var mathCourseToUpdate = db.MathCourses.FirstOrDefault(mc => mc.Id == id);

                if (mathCourseToUpdate != null)
                {
                    Console.WriteLine("New MathInstructor:");
                    var newMathInstructor = Console.ReadLine();

                    Console.WriteLine("New MathTopic:");
                    var newMathTopic = Console.ReadLine();

                    // Update the properties of the MathCourse
                    mathCourseToUpdate.MathInstructor = newMathInstructor;
                    mathCourseToUpdate.MathTopic = newMathTopic;

                    db.SaveChanges();

                    Console.WriteLine("Update successful");
                }
                else
                {
                    Console.WriteLine("MathCourse with the provided ID not found");
                }
            }
        }

        public void Delete1(int id)
        {
            using (var db = new btBuoi3Context())
            {
                var englishCourseToUpdate = db.EnglishCourses.FirstOrDefault(ec => ec.EnglishCoursesid == id);

                if (englishCourseToUpdate != null)
                {
                    db.EnglishCourses.Remove(englishCourseToUpdate);
                    db.SaveChanges();

                    Console.WriteLine("remove successful");
                 

                }
                else
                {
                    Console.WriteLine("EnglishCourse with the provided ID not found");
                }
            }
        }

        public void Delete2(int id)
        {
            using (var db = new btBuoi3Context())
            {
                var englishCourseToUpdate = db.MathCourses.FirstOrDefault(ec => ec.Id == id);

                if (englishCourseToUpdate != null)
                {
                    db.MathCourses.Remove(englishCourseToUpdate);
                    db.SaveChanges();

                    Console.WriteLine("remove successful");
                }
                else
                {
                    Console.WriteLine("EnglishCourse with the provided ID not found");
                }
            }
        }
        public void display1()
        {
            using (var db = new btBuoi3Context())
            {
                foreach (var e in db.EnglishCourses)
                {
                    Console.WriteLine($"{e.EnglishCoursesid}\t{e.EnglishInstructor}\t{e.EnglishTopic}");
                }
            }
        }
        public void display2()
        {
            using (var db = new btBuoi3Context())
            {
                foreach (var e in db.MathCourses)
                {
                    Console.WriteLine($"{e.Id}\t{e.MathInstructor}\t{e.MathTopic}\t");
                }
            }
        }
        static string FormatListContent1(List<EnglishCourse> englishCourses)
        {
            if (englishCourses == null || englishCourses.Count == 0)
            {
                return string.Empty; // Return an empty string if the list is empty or null
            }

            StringBuilder builder = new StringBuilder();

            using (var db = new btBuoi3Context())
            {
                foreach (var e in db.EnglishCourses)
                {
                    builder.AppendLine($"{e.EnglishCoursesid}\t{e.EnglishInstructor}\t{e.EnglishTopic}");
                }
            }

            return builder.ToString();
        }

        static string FormatListContent2(List<MathCourse> mathCourses)
        {
            if (mathCourses == null || mathCourses.Count == 0)
            {
                return string.Empty; // Return an empty string if the list is empty or null
            }
            StringBuilder builder = new StringBuilder();

            // Assuming T has properties id, Speed, RegularPrice, and Length
         //   builder.AppendLine("ID\tSpeed\tRegularPrice\tYear\tManufacturerDiscount");
            using (var db = new btBuoi3Context())
            {
                foreach (var e in db.MathCourses)
                {
                    builder.AppendLine($"{e.Id}\t{e.MathInstructor}\t{e.MathTopic}\t");
                }
            }

            return builder.ToString();
        }

    }




}
