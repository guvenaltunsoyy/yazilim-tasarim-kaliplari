namespace AdapterPattern
{
    public class User
    {
        public string FullName{ get; set; }
        public string Mail { get; set; }
        public string PhoneNumber { get; set; }
        public int Age { get; set; }

        public User()
        {
            
        }
        public User(string fullName, string mail, string phoneNumber, int age)
        {
            FullName = fullName;
            Mail = mail;
            PhoneNumber = phoneNumber;
            Age = age;
        }
    }
}