using ConsoleApp1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using btbuoi2;
namespace btbuoi2.Manager
{

    internal class CarManager : ICarManager {



        public void DeletData()
        {
            Console.WriteLine("Select a category:");
            Console.WriteLine("1. Sedan");
            Console.WriteLine("2. Truck");
            Console.WriteLine("3. Ford");
            int categoryChoice = Convert.ToInt32(Console.ReadLine());

            switch (categoryChoice)
            {
                case 1:
                    DeleteVehicle(lista);
                    break;
                case 2:
                    DeleteVehicle(listb);
                    break;
                case 3:
                    DeleteVehicle(listc);
                    break;
                default:
                    Console.WriteLine("Invalid category choice.");
                    break;
            }
        }

        public void Display()
        {
            Console.WriteLine("Select a category:");
            Console.WriteLine("1. Sedan");
            Console.WriteLine("2. Truck");
            Console.WriteLine("3. Ford");
            int categoryChoice = Convert.ToInt32(Console.ReadLine());

            switch (categoryChoice)
            {
                case 1:
                    Display1(lista);
                    break;
                case 2:
                    Display2(listb);
                    break;
                case 3:
                    Display3(listc);
                    break;
                default:
                    Console.WriteLine("Invalid category choice.");
                    break;
            }


        }
        List<Sedan> lista = new List<Sedan>();
        List<Truck> listb = new List<Truck>();
        List<Ford> listc = new List<Ford>();
        public void InputData()
        {
            bool checkCha = true;
            do
            {
                switch (Menu.GetOptionMenuAddAndGet())
                {
                    case 1:
                        //Chon the loai xe them vao 1 la sedan
                        Sedan s = new Sedan();
                        s.Add();
                        lista.Add(s);
                        break;
                    case 2:
                        //Chon the loai xe them vao 2 la Truck
                        Truck t = new Truck();
                        t.Add();
                        listb.Add(t);
                        break;
                    case 3:
                        //Chon the loai xe them vao 3 la Ford
                        Ford f = new Ford();
                        f.Add();
                        listc.Add(f);
                        break;
                    default:
                        Console.WriteLine("Invalid category choice.");
                        break;
                }

                Console.WriteLine("Do you want to add more vehicles? (yes/no)");
                string userInput = Console.ReadLine();
                checkCha = userInput.ToLower() == "yes";

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
                case 3:
                    Console.WriteLine("Enter the ID of the Ford to update:");
                    int fordId = int.Parse(Console.ReadLine());
                    Update3(fordId);
                    break;
                default:
                    Console.WriteLine("Invalid category choice.");
                    break;
            }
        }

        void Update1(int idToUpdate)
        {
            // Find the car with the provided ID
            var carToUpdate = lista.FirstOrDefault(car => car.id == idToUpdate);

            if (carToUpdate != null && carToUpdate is Sedan sedanToUpdate)
            {
                Console.Write("RegularPrice: ");
                sedanToUpdate.RegularPrice = double.Parse(Console.ReadLine());

                Console.Write("color: ");
                sedanToUpdate.Color = Console.ReadLine();

                Console.Write("speed: ");
                sedanToUpdate.Speed = decimal.Parse(Console.ReadLine());

                Console.Write("Enter Length: ");
                int Length;
                while (!int.TryParse(Console.ReadLine(), out Length))
                {
                    Console.WriteLine("Invalid value! Try again.");
                    Console.Write("Re-Enter Length: ");
                }
                sedanToUpdate.Length = Length;

                Console.WriteLine("Update successful");
            }
            else
            {
                Console.WriteLine("Sedan with the provided ID not found");
            }
        }


        void Update2(int idToUpdate)
        {
            // Find the car with the provided ID
            var carToUpdate = listb.FirstOrDefault(car => car.id == idToUpdate);

            if (carToUpdate != null && carToUpdate is Truck t)
            {
                Console.Write("RegularPrice: ");
                t.RegularPrice = double.Parse(Console.ReadLine());

                Console.Write("color: ");
                t.Color = Console.ReadLine();

                Console.Write("speed: ");
                t.Speed = decimal.Parse(Console.ReadLine());

                Console.Write("Enter Weight:");
                int Weight;
                while (!int.TryParse(Console.ReadLine(), out Weight))
                {
                    Console.WriteLine("Invalid value! Try again.");
                    Console.Write("Re-Enter Weight:");
                }
                t.Weight = Weight;

                Console.WriteLine("Update successful");
            }
            else
            {
                Console.WriteLine("Truck with the provided ID not found");
            }
        }

        void Update3(int idToUpdate)
        {
            // Find the car with the provided ID
            var carToUpdate = listc.FirstOrDefault(car => car.id == idToUpdate);

            if (carToUpdate != null && carToUpdate is Ford f)
            {
                Console.Write("RegularPrice: ");
                f.RegularPrice = double.Parse(Console.ReadLine());

                Console.Write("color: ");
                f.Color = Console.ReadLine();

                Console.Write("speed: ");
                f.Speed = decimal.Parse(Console.ReadLine());

                Console.Write("Enter Year:");
                int Year;
                while (!int.TryParse(Console.ReadLine(), out Year))
                {
                    Console.WriteLine("Invalid value!Try again.");
                    Console.Write("Re-Enter Year:");
                }
                f.Year = Year;


                Console.Write("Enter ManufacturerDiscount:");
                int ManufacturerDiscount;
                while (!int.TryParse(Console.ReadLine(), out ManufacturerDiscount))
                {
                    Console.WriteLine("Invalid value!Try again.");
                    Console.Write("Re-Enter ManufacturerDiscount:");
                }
                f.ManufacturerDiscount = ManufacturerDiscount;

                Console.WriteLine("Update successful");
            }
            else
            {
                Console.WriteLine("Truck with the provided ID not found");
            }
        }
        private void DisplayVehicles<T>(List<T> vehicleList) where T : Cars
        {
            foreach (var vehicle in vehicleList)
            {
                vehicle.ToString();
            }
        }
        //void Delete1(int idToUpdate)
        //{
        //    // Find the car with the provided ID
        //    var carToUpdate = lista.FirstOrDefault(car => car.id == idToUpdate);

        //    if (carToUpdate != null && carToUpdate is Sedan t)
        //    {
        //        lista.Remove(carToUpdate);
        //        Console.WriteLine("delete thanh cong");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Truck with the provided ID not found");
        //    }
        //}

        //void Delete2(int idToUpdate)
        //{
        //    // Find the car with the provided ID
        //    var carToUpdate = listb.FirstOrDefault(car => car.id == idToUpdate);

        //    if (carToUpdate != null && carToUpdate is Truck t)
        //    {
        //        listb.Remove(carToUpdate);
        //        Console.WriteLine("delete thanh cong");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Truck with the provided ID not found");
        //    }
        //}

        //void Delete3(int idToUpdate)
        //{
        //    // Find the car with the provided ID
        //    var carToUpdate = listc.FirstOrDefault(car => car.id == idToUpdate);

        //    if (carToUpdate != null && carToUpdate is Ford t)
        //    {
        //        listc.Remove(carToUpdate);
        //        Console.WriteLine("delete thanh cong");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Truck with the provided ID not found");
        //    }
        //}
        void Display1(List<Sedan> lista)
        {
            //dislay list sedan
            Console.WriteLine("ID\tSpeed\tRegularPrice\tLength");
            foreach (var e in lista)
            {
                Console.WriteLine($"{e.id}\t{e.Speed}\t{e.RegularPrice}\t{e.Length}");
            }
        }
        void Display2(List<Truck> listb)
        {
            Console.WriteLine("ID\tSpeed\tRegularPrice\tWeight");
            foreach (var e in listb)
            {
                Console.WriteLine($"{e.id}\t{e.Speed}\t{e.RegularPrice}\t{e.Weight}");
            }
        }
        void Display3(List<Ford> listc)
        {
            Console.WriteLine("ID\tSpeed\tRegularPrice\tYear\tManufacturerDiscount");
            foreach (var e in listc)
            {
                Console.WriteLine($"{e.id}\t{e.Speed}\t{e.RegularPrice}\t{e.Year}\t{e.ManufacturerDiscount}");
            }
        }
        private void AddVehicle<T>(List<T> vehicleList, T Cars) where T : Cars, new()
        {
            Cars.Add();
            vehicleList.Add(Cars);
        }
    

        private void DeleteVehicle<T>(List<T> vehicleList) where T : Cars
        {
            Console.WriteLine("Enter the ID of the vehicle to delete:");
            int vehicleId = int.Parse(Console.ReadLine());

            var vehicleToDelete = vehicleList.FirstOrDefault(vehicle => vehicle.id == vehicleId);

            if (vehicleToDelete != null)
            {
                vehicleList.Remove(vehicleToDelete);
                Console.WriteLine("Delete successful");
            }
            else
            {
                Console.WriteLine("Vehicle with the provided ID not found");
            }
        }

        public void SaveFile()
        {
            Console.WriteLine("Select a category:");
            Console.WriteLine("1. Sedan");
            Console.WriteLine("2. Truck");
            Console.WriteLine("3. Ford");
            string contentToSave = "";
            int categoryChoice = Convert.ToInt32(Console.ReadLine());

            switch (categoryChoice)
            {
                case 1:
                    contentToSave = FormatListContent(lista);
                    break;
                case 2:
                    contentToSave = FormatListContent1(listb);
                    break;
                case 3:
                    contentToSave = FormatListContent2(listc);
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
        static string FormatListContent<T>(List<T> lista)
        {
            if (lista == null || lista.Count == 0)
            {
                return string.Empty; // Return an empty string if the list is empty or null
            }

            StringBuilder builder = new StringBuilder();

            // Assuming T has properties id, Speed, RegularPrice, and Length
            builder.AppendLine("ID\tSpeed\tRegularPrice\tLength");
            foreach (var item in lista)
            {
                dynamic dynamicItem = item;
                builder.AppendLine($"{dynamicItem.id}\t{dynamicItem.Speed}\t{dynamicItem.RegularPrice}\t{dynamicItem.Length}");
            }

            return builder.ToString();
        }
        static string FormatListContent1<T>(List<T> listb)
        {
            if (listb == null || listb.Count == 0)
            {
                return string.Empty; // Return an empty string if the list is empty or null
            }

            StringBuilder builder = new StringBuilder();

            // Assuming T has properties id, Speed, RegularPrice, and Length
            builder.AppendLine("ID\tSpeed\tRegularPrice\tWeight");
            foreach (var item in listb)
            {
                dynamic dynamicItem = item;
                builder.AppendLine($"{dynamicItem.id}\t{dynamicItem.Speed}\t{dynamicItem.RegularPrice}\t{dynamicItem.Weight}");
            }

            return builder.ToString();
        }
        static string FormatListContent2<T>(List<T> listc)
        {
            if (listc == null || listc.Count == 0)
            {
                return string.Empty; // Return an empty string if the list is empty or null
            }
            StringBuilder builder = new StringBuilder();

            // Assuming T has properties id, Speed, RegularPrice, and Length
            builder.AppendLine("ID\tSpeed\tRegularPrice\tYear\tManufacturerDiscount");
            foreach (var item in listc)
            {
                dynamic dynamicItem = item;
                builder.AppendLine($"{dynamicItem.id}\t{dynamicItem.Speed}\t{dynamicItem.RegularPrice}\t{dynamicItem.Year}\t{dynamicItem.ManufacturerDiscount}");
            }

            return builder.ToString();
        }
    }






}
