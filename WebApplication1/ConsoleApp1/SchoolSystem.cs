using System;
using System.Transactions;

namespace ConsoleApp1
{
    class SchoolSystem
    {
        private YearDate _cutoff;
        private int _minAge;
        private YearDate _schoolStart;
    
        public SchoolSystem(YearDate cutoff, int minAge, YearDate schoolStart)
        {
            _cutoff = cutoff;
            _minAge = minAge;
            _schoolStart = schoolStart;
        }

        public Date GetBeginning(Child schoolChild) =>
            schoolChild
                .GetDateByAge(_minAge)
                .GetFirstOccurrence(_cutoff)
                .GetFirstOccurrence(_schoolStart);
    }
}