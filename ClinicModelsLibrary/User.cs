using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicModelsLibrary
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }        
        public string Password { get; set; }
        public string Type { get; set; }


        public void TakeDetails()
        {
           
            Console.WriteLine("Please enter Name:");
            Name = Console.ReadLine();
            Console.WriteLine("Please enter Password:");
            Password = Console.ReadLine();
            Console.WriteLine("Are you a patient or doctor?:");
            Type = Console.ReadLine();
           

        }

        

       

    }
}

    
