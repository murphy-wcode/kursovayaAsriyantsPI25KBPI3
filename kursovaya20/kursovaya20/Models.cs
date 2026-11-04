using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace kursovaya20
{
    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Role { get; set; } 
        public string FullName { get; set; }
        public string Email { get; set; }
    }

    public class Pet
    {
        public string Name { get; set; }
        public string Species { get; set; } 
        public string Breed { get; set; }  
        public string OwnerLogin { get; set; } 
    }

    public class Doctor
    {
        public string FullName { get; set; }
        public string Specialization { get; set; }
    }

    public class Appointment
    {
        public string OwnerLogin { get; set; } 
        public string PetName { get; set; }    
        public string DoctorName { get; set; } 
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }   
        public decimal Price { get; set; }      
        public string Status { get; set; }     
    }

    public static class DataStore
    {
        public static List<User> Users = new List<User>();
        public static List<Pet> Pets = new List<Pet>();
        public static List<Doctor> Doctors = new List<Doctor>();
        public static List<Appointment> Appointments = new List<Appointment>();

        public static User CurrentUser = null;

        static DataStore()
        {
            Doctors.Add(new Doctor { FullName = "Иванов И.И.", Specialization = "Терапевт" });
            Doctors.Add(new Doctor { FullName = "Петрова А.С.", Specialization = "Хирург" });
            Doctors.Add(new Doctor { FullName = "Сидоров В.В.", Specialization = "Офтальмолог" });
        }

        public static bool LoginExists(string login)
        {
            return Users.Exists(u => u.Login == login);
        }
    }
}