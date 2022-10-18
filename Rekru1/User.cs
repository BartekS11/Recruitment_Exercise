using System.Text.RegularExpressions;

public class User {
    public string Name { get; protected set; }
    public string Surname { get; protected set; }
    public string Email { get; protected set; }
    public DateTime BirthDate { get; protected set; }

    private readonly Regex _validateEmailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

    public void SetEmail(string email)
    {
        if(string.IsNullOrWhiteSpace(email))
        {
            throw new Exception("Email is empty");
        }
        if(!!!_validateEmailRegex.IsMatch(email))
        {
            throw new Exception("Enter valid email address");
        }
        Email = email;
    }

    public void SetName(string name)
    {
        if(string.IsNullOrWhiteSpace(name))
        {
            throw new Exception("Name is empty");
        }
        Name = name;
    }

    public void SetSurname(string surname)
    {
        if(string.IsNullOrWhiteSpace(surname))
        {
            throw new Exception("Surname is empty");
        }
        Surname = surname;
    }

//    public void SetBirthDate(DateTime birthDate)
//    {
//        if(birthDate >= DateTime.UtcNow)
//        {
//            throw new Exception("Insert correct birth date");
//        }
//        BirthDate = birthDate;
//    }

    public User(string name, string surname, string email, DateTime birthDate)
    {
        SetName(name);
        SetSurname(surname);
        SetEmail(email);
//        SetBirthDate(birthDate);
        BirthDate = birthDate;
    }

}