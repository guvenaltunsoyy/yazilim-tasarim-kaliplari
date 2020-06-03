using System;

namespace AdapterPattern
{
    public class Operations
    {
        private IExtension _extension;

        public Operations(IExtension extension)
        {
            _extension = extension;
        }

        public UserModel GetUserModel(User user, School school, Address address)
        {
            return _extension.ToUserModel(user, school, address);
        }

        public void CallAPI(UserModel userModel)
        {
            Console.WriteLine($"{userModel.FullName} sunucuda olusturuldu.");
        }
    }
}