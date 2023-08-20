
using ConsoleApp2.Manager;

while (true)
{
    // Create an instance of CarManager (assuming CarManager implements ICarManager)
    ICarManager car = new CarManager();
    Console.WriteLine("1. Xem danh sach xe");
    Console.WriteLine("2. nhap xe");
    Console.WriteLine("3.update xe");
    Console.WriteLine("4. xoa vehicle");
    Console.WriteLine("5. thoat");
    Console.WriteLine("6. Luu file vao duong dan");
    // vd  D:\PRN211_BL5\ConsoleApp1\btbuoi2\btb2.txt
    Console.Write("Select an option: ");
    int categoryChoice = Convert.ToInt32(Console.ReadLine());
    switch (categoryChoice)
    {
        case 1:
            //  car.Display();
            car.Display();
            break;
        case 2:
            // car.InputData();
            car.InputData();    
            break;
        case 3:
            car.UpdateData();
           // car.UpdateData();
            break;
        case 4:
            car.DeleteData();
            break;
        case 5:
            Environment.Exit(0);
            break;

        case 6:
       car.SaveFile();


            break;





    }
}
