
namespace AdapterPattern
{
    public class UserModel : User
    {
        public School School { get; set; }
        public Address Address { get; set; }

        public override string ToString()
        {
            return $"{FullName}\n" +
                   $"{School.Name}, {School.Department}, {School.Grade}.sinif, {School.Degree}\n" +
                   $"{Address.Street} {Address.State} {Address.City}/{Address.Country}, {Address.ZipCode}\n";
        }
    }
}