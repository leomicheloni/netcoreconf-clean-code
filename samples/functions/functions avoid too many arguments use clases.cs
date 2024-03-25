//// Functions, avoid too many arguments, use clases instead
// Mal
public void Register(string name, string lastName, int age, string email, string country)
{
    // ...
}

// Bien
public class User
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
    public string Country { get; set; }

    public User(string name, string lastName, int age, string email, string country)
    {
        Name = name;
        LastName = lastName;
        Age = age;
        Email = email;
        Country = country;
    }
}

public void RegisterUser(User user)
{
    // ...
}

