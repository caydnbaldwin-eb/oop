class UserIdentity
{
    private string firstName;
    private string middleName;
    private string lastName;
    public int age;
    public string fullName;

    public UserIdentity(string fN, string mN, string lN, int a)
    {
        firstName = fN;
        middleName = mN;
        lastName = lN;
        age = a;
        fullName = $"{firstName} {middleName} {lastName}";
    }

    public string Stringify()
    {
        return $"{fullName} is {age} years old.";
    }
}

class Comparison
{
    public UserIdentity user1;
    public UserIdentity user2;

    public Comparison(UserIdentity u1, UserIdentity u2)
    {
        user1 = u1;
        user2 = u2;
    }

    public string Stringify()
    {
        int difference = Math.Abs(user1.age - user2.age);

        if (user1.age > user2.age)
        {
            return $"{user1.fullName} is {difference} years older than {user2.fullName}.";
        } else 
        {
            return $"{user2.fullName} is {difference} years older than {user1.fullName}.";
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        string fN = "Caydn";
        string mN = "Andrew";
        string lN = "Baldwin";
        int a = 21;

        UserIdentity user1 = new UserIdentity(fN, mN, lN, a);
        string message = user1.Stringify();

        System.Console.WriteLine(message);
        System.Console.ReadLine();
        
        fN = "Dalyn";
        mN = "Lockett";
        lN = "Baldwin";
        a = 25;
        
        UserIdentity user2 = new UserIdentity(fN, mN, lN, a);
        message = user2.Stringify();
        
        System.Console.WriteLine(message);
        System.Console.ReadLine();

        Comparison comparison1 = new Comparison(user1, user2);
        message = comparison1.Stringify();

        System.Console.WriteLine(message);
        System.Console.ReadLine();
    }
}