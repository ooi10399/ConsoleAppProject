using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicModelsLibrary;


namespace Clinic
{
    class ManageAppointment
    {
        List<Appointment> appointments = new List<Appointment>();
        private int GenerateId()
        {            
            if (appointments.Count == 0)
            {
                return 1;
            }
            else
            {
                return appointments.Count + 1;
            }
            
        }

        int GetIdFromUser()
        {
            Console.WriteLine("Please enter the appointment id");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Invalid entry ID. Please try again...");
            }
            return id;
        }

        public Appointment GetAppointmentById(int id)
        {

            Appointment appointment = appointments.Find(p => p.Id == id);
            return appointment;
        }

        public void AddAppointment()
        {
            Appointment a = new Appointment();
            a.Id = GenerateId();
            a.AppointmentDetails();
            appointments.Add(a);         

        }

        public void EditAppointment()
        {

            int id = GetIdFromUser();
            Appointment a = GetAppointmentById(id);
            if (a == null)
            {
                Console.WriteLine("Invalid Id. Cannot edit");
                return;
            }
            Console.WriteLine("The selected appointment to edit");
            PrintAppointment(a);
            a.AppointmentDetails();
            Console.WriteLine("Updated. New Details");
            PrintAppointment(a);

        }

        public void DeleteAppointment()
        {

            int id = GetIdFromUser();
            int idx = -1;
            for (int i = 0; i < appointments.Count; i++)
            {
                if (appointments[i].Id == id)
                {
                    idx = i;
                }               
            }
            Appointment a = GetAppointmentById(id);
            if (idx != -1)
            {
                Console.WriteLine("Confirm delete? (Yes/No):");
                PrintAppointment(a);
                string confirmation = Console.ReadLine();
                if (confirmation == "Yes")
                {
                    appointments[idx] = null;
                    Console.WriteLine("Appoinment Deleted Successfully");
                }
                    
            }

        }

        public void PrintAppointment(Appointment a)
        {
            Console.WriteLine("**************************");
            Console.WriteLine(a);
            Console.WriteLine("**************************");
        }

        public void PrintAppointmentById()
        {
            int id = GetIdFromUser();
            Appointment a = GetAppointmentById(id);
            if (a != null)
            {
                PrintAppointment(a);
            }
                
        }       

        public void PrintAllAppointments()
        {
            appointments.Sort();
            foreach (var a in appointments)
            {
                if (a != null)
                {
                    PrintAppointment(a);
                }
            }

        }
        
    }
}
