using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Report(Child child, SchoolSystem school)
        {
            Console.WriteLine(
                child + " starts school on " + school.GetBeginning(child) +
                ", celebrates on " + child.GetFirstCelebration(school)
            );
        }

        static void Demonstrate(Calendar cal)
        {
            SchoolSystem school = new SchoolSystem(cal.Create(3, 1), 5, cal.Create(8, 15));

            Child jill = new Child("Jill", new Date(cal, 1892, cal.Create(2, 29)));
            Child jake = new Child("Jake", new Date(cal, 1891, cal.Create(8, 27)));

            Report(jill, school);
            Report(jake, school);
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Demonstrate(new GregorianCalendar());
            Demonstrate(new JulianCalendar());
            Console.ReadLine();
        }
    }
}