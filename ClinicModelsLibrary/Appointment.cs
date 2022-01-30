using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicModelsLibrary
{
    public class Appointment :IComparable
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        


        public void AppointmentDetails()
        {
            Console.WriteLine("Appointment Date: ");
            Date = Console.ReadLine();
            Console.WriteLine("Appointment Time: ");
            Time = Console.ReadLine();
        }

        public int CompareTo(object obj)
        {
            Appointment a1, a2;
            a1 = this;
            a2 = (Appointment)obj;
            return a1.Date.CompareTo(a2.Date);
        }

        public override string ToString()
        {
            return "Appointment ID: " + Id
                + "\nAppointment Date: " + Date
                + "\nAppointment Time: " + Time;
        }

    }

}
