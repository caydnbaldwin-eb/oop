using System;
using System.Globalization;
using System.Linq.Expressions;

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

        static void Report(Child[] children, SchoolSystem school)
        {
            foreach (Child child in children)
                Report(child, school);
        }

        static void Demonstrate(Calendar cal)
        {
            SchoolSystem school = new(cal.Create(3, 1), 5, cal.Create(8, 15));

            Child[] children = new Child[]
            {
                new Child("Jill", cal.Create(2008, 2, 29)),
                new Child("Jake", cal.Create(2007, 8, 27)),
                new Child("Jimmy", cal.Create(2008, 1, 31)),
                new Child("Jane", cal.Create(2009, 4, 22)),
                new Child("John", cal.Create(2007, 11, 14))
            };

            Report(children, school);
            Console.WriteLine();
        }

        static void AddCalendars(List<Calendar> calendars, JulianCalendar calendar) => 
            calendars.Add(calendar);

        static void Main(string[] args)
        {
            List<Calendar> calendars = new List<Calendar>
            {
                new GregorianCalendar()
            };
            AddCalendars(calendars, new JulianCalendar());

            foreach (Calendar calendar in calendars)
                Demonstrate(calendar);

            Console.ReadLine();
        }

    }
}