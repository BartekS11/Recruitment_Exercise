public class Repository {

    private List<User> _userList = new List<User>()
    {
        new User("Adas", "Malysz", "wojciech@wi.pl", new DateTime(1990, 4, 20)),
        new User("Mariusz", "Pudzilla", "w35@wi.pl", new DateTime(1992, 11, 3)),
        new User("Kasia", "Nowak", "fd@vx.pl", new DateTime(1988, 3, 31)),
        new User("Tomasz", "Taras", "zzzz@user.pl", new DateTime(1995, 5, 5)),
        new User("Filip", "Kubski", "ema@emayr.pl", new DateTime(1992, 11, 3))
    };

    public void AddPerson(User user)
    {
        _userList.Add(user);
    }

    public void SearchBy(string name)
    {
        var foundUser = _userList.Find(user =>
                                           user.Name == name
                                        || user.Email == name
                                        || user.Surname == name
                                        || user.BirthDate.ToString("dd/MM/yyyy") == name);
        Console.WriteLine($@"Found user: {foundUser.Name}, {foundUser.Surname}, {foundUser.Email}");
    }

    public void OrderBySurnameDesc()
    {
        _userList.Sort((x, y) => x.Surname.CompareTo(y.Surname));
        Console.WriteLine("Sorted list: ");
        foreach( var i in _userList)
        {
            Console.WriteLine(i.Surname);
        }
    }

    public User LongestSurname()
    {
        var userWithLongestSurname = _userList.OrderByDescending(user => user.Surname.Length).First();
        Console.WriteLine(userWithLongestSurname.Surname);
        return userWithLongestSurname;
    }

    public void ReverseName()
    {
        foreach( var i in _userList)
        {
            var array = i.Name.ToCharArray();
            Array.Reverse(array);
            Console.WriteLine(new string(array));
        }
    }

    public void YoungestUser()
    {
        var youngestUser = _userList.OrderByDescending(user => user.BirthDate.Year).First();
        Console.WriteLine(youngestUser.Surname);
    }

}