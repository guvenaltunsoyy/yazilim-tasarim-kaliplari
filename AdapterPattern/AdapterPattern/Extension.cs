using System;

namespace AdapterPattern
{
    public class Extension : IExtension
    {
        public UserModel ToUserModel(User user, School school, Address address)
        {
            var u = new UserModel
            {
                FullName = user.FullName,
                Age = user.Age,
                PhoneNumber = user.PhoneNumber,
                Mail = user.Mail,
                Address = address,
                School = school
            };
            Console.WriteLine(u.ToString());
            return u;
        }
    }
}