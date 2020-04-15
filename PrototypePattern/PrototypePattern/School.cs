using System;
namespace PrototypePattern
{
    [Serializable]
    public class School
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }

    [Serializable]
    public class Student : IPrototypePattern<Student>
    {
        public string FullName { get; set; }
        public int SchoolNumber { get; set; }
        public School School { get; set; }

    }
}
