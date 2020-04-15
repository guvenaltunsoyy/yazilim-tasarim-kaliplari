using System;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-- Shallow Copy --");

            Student student1 = new Student() { FullName = "Güven", SchoolNumber = 1 };
            student1.School = new School() { Name = "Kocaeli" };
            Console.WriteLine(student1.FullName + " " + student1.School.Name + " " + student1.SchoolNumber);

            Student student2 = student1.Clone();
            Console.WriteLine(student2.FullName+" "+ student2.School.Name +" "+ student2.SchoolNumber);

            student2.FullName = "Mehmet";
            student2.SchoolNumber = 2;
            student2.School.Name = "Biruni Üniversitesi";

            Console.WriteLine();
            Console.WriteLine("After Change:");

            Console.WriteLine(student1.FullName + " " + student1.School.Name + " " + student1.SchoolNumber);
            Console.WriteLine(student2.FullName + " " + student2.School.Name + " " + student2.SchoolNumber);

            #region Deep Copy
            Console.WriteLine();
            Console.WriteLine("-- Deep Copy --");

            Student student3 = new Student() { FullName = "Güven", SchoolNumber = 1 };
            student3.School = new School() { Name = "İTÜ" };

            Console.WriteLine(student3.FullName + " " + student3.School.Name + " " + student3.SchoolNumber);

            Student student4 = student3.DeepCopy();

            Console.WriteLine(student4.FullName + " " + student4.School.Name + " " + student4.SchoolNumber);

            student4.FullName = "Ahmet";
            student4.SchoolNumber = 2;
            student4.School.Name = "Kırklareli üniversitesi";

            Console.WriteLine();
            Console.WriteLine("After Change:");
            Console.WriteLine(student3.FullName + " " + student3.School.Name + " " + student3.SchoolNumber);
            Console.WriteLine(student4.FullName + " " + student4.School.Name + " " + student4.SchoolNumber);
            Console.ReadLine();


            #endregion

        }
    }
}
