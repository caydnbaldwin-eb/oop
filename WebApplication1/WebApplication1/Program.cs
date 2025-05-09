class SchoolCalendar
{
    private int schoolMonth;
    private int schoolDay;
    private int minAge;

    public SchoolCalendar(int sm, int sd, int age)
    {
        schoolMonth = sm;
        schoolDay = sd;
        minAge = age;
    }
    
    public int GetSchoolDate(int birthdate)
    {
        int schoolDate = (birthdate / 10000 + minAge) * 10000 + schoolMonth * 100 + schoolDay;
        if (birthdate % 10000 > schoolMonth * 100 + schoolDay)
        {
            schoolDate = schoolDate + 10000;
        }
        return schoolDate;
    }

    public virtual bool IsLeap(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
    }

    public int GetSchoolBirthday(int birthdate)
    {
        int schoolDate = GetSchoolDate(birthdate);
        int birthdayYear = schoolDate / 10000;

        if (birthdate % 10000 < schoolDate % 10000)
        {
            birthdayYear = birthdayYear + 1;
        }

        if (birthdate % 10000 == 2 * 100 + 29 && !IsLeap(birthdayYear))
        {
            birthdayYear = (birthdayYear + 3) / 4 * 4;
            if (!IsLeap(birthdayYear))
            {
                birthdayYear = birthdayYear + 4;
            }
        }
        int birthday = birthdayYear * 10000 + birthdate % 10000;
        return birthday;
    }
}

class JulianSchoolCalendar : SchoolCalendar
{
    public JulianSchoolCalendar(int sm, int sd, int age) : base(sm, sd, age)
    {
    }

    public override bool IsLeap(int year)
    {
        return year % 4 == 0;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int birthdate = 20160229;

        SchoolCalendar calendar1 = new SchoolCalendar(9, 1, 6);
        int schoolDate = calendar1.GetSchoolDate(birthdate);

        SchoolCalendar calendar2 = new JulianSchoolCalendar(9, 1, 5);
        int alternateSchoolDate = calendar2.GetSchoolDate(birthdate);
        int alternateBirthday = calendar2.GetSchoolBirthday(birthdate);

        int birthday = calendar1.GetSchoolBirthday(birthdate);

        System.Console.WriteLine(schoolDate);
        System.Console.WriteLine(alternateSchoolDate);
        System.Console.WriteLine(birthday);

        System.Console.ReadLine();
    }
}
