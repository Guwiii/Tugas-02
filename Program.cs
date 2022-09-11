//Gunawan Dwi Wicaksono, NRP: 5220600049 
using System;
using System.IO;
using System.Text.Json;

namespace LoginJson
{
    class User
    {
        public int TotalID { get; set; }
        public string ID { get; set; }
        public int TotalPass { get; set; }
        public string Password { get; set; }
    }
    class UsPass
    {
        static void Main()
        {
            Console.WriteLine("-----Hello! Please insert your details-----");
            User user = new User();
            Console.WriteLine("ID : ");
            user.ID = Console.ReadLine();
            Console.WriteLine("Password : ");
            user.Password = Console.ReadLine();

            user.TotalID = user.ID.Length;
            user.TotalPass = user.Password.Length;

            string UserDetails = "Details.json";
            string jsonString = JsonSerializer.Serialize(user);
            File.WriteAllText(UserDetails, jsonString);

            Console.WriteLine(File.ReadAllText(UserDetails));
        }
    }
}