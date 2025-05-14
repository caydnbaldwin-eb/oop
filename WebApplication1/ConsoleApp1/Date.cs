using System;

namespace ConsoleApp1
{
    class Date
    {
        private int _year;
        private YearDate _day;

        public Date(int year, YearDate day)
        {
            _year = year;
            _day = day;
        }

        public Date AddYears(int count) =>
            FirstValidDate(_year + count, _day);

        private Date FirstValidDate(int year, YearDate day) =>
            day.IsLeap() && !IsLeap(year) ? new Date(year, day.GetNext())
            : new Date(year, day);

        public Date GetFirstDayOccurrence(Date day) =>
            GetFirstDayOccurrence(_year, day._day);

        private bool IsLeap(int year) =>
            year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);

        public Date GetFirstOccurrence(YearDate day) =>
            GetFirstDayOccurrence(day.IsBefore(_day) ? _year + 1 : _year, day);

        private Date GetFirstDayOccurrence(int year, YearDate day) => 
            new Date(day.IsLeap() ? GetLeap(year) : year, day);

        private int GetLeap(int year) => 
            IsLeap(year) ? year : GetLeap(year + 1);

        public override string ToString() =>
            _day + "/" + _year;
    }       
}