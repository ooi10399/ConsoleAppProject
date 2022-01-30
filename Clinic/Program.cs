using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicModelsLibrary;


namespace Clinic
{
    class Program
    {
        public void Run()
        {
            ManageAppointment m = new ManageAppointment();
            int choice = 0;
            do
            {
                Console.WriteLine("Choose from the options");
                Console.WriteLine("1. View your appointments");
                Console.WriteLine("2. Add new appointment");
                Console.WriteLine("3. Edit appointment");
                Console.WriteLine("4. Delete appointment");
                Console.WriteLine("0. Exit");
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Try again. Please enter a number");
                }
                switch (choice)
                {
                    case 1:
                        m.PrintAllAppointments();
                        break;
                    case 2:
                        m.AddAppointment();
                        break;
                    case 3:
                        m.EditAppointment();
                        break;
                    case 4:
                        m.DeleteAppointment();
                        break;
                    case 0:
                        Console.WriteLine("Bey bye..........");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again");
                        break;
                }
            } while (choice != 0);
        }
    
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();            
            Console.ReadKey();
        }
    }
}
