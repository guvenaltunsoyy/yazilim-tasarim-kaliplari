using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adapter Pattern");
                        
            var user= new User("Guven ALTUNSOY","gven.altunsoy@gmail.com","5332186219", 25);
            var school = new School("Kocaeli Universitesi", "Bilgisayar Muhendisligi","Lisans",4);
            var address = new Address("Istanbul","Gaziosmanpasa", "Turkiye","43.sk",34250);
            
            var operations = new Operations(new Extension());

            var userModel = operations.GetUserModel(user, school, address);
            operations.CallAPI(userModel);
        }
    }
}