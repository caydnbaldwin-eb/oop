using System;

namespace ConsoleApp1
{
    class JulianCalendar : Calendar
    {
        public override bool IsLeapYear(int year) => 
            year % 4 == 0;
    }
}