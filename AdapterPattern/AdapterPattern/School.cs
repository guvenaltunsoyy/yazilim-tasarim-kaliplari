namespace AdapterPattern
{
    public class School
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public string Degree { get; set; }
        public int Grade { get; set; }

        public School(string name, string department, string degree, int grade)
        {
            Name = name;
            Department = department;
            Degree = degree;
            Grade = grade;
        }
    }
    
}