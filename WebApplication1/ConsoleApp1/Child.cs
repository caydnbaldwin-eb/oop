using System;

namespace ConsoleApp1
{
    class Child
    {
        private string _name;
        private Date _birthdate;

        public Child(string name, Date birthdate)
        {
            _name = name;
            _birthdate = birthdate;
        }

        public Date GetDateByAge(int age) =>
            _birthdate.AddYears(age);

        public Date GetFirstCelebration(SchoolSystem school) => 
            school.GetBeginning(this).GetFirstDayOccurrence(_birthdate);

        public override string ToString() =>
            _name + " born on " + _birthdate;
    }
}