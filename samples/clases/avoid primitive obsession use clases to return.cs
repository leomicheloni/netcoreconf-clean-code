//// Classes, avoid primitive return types, use classes
// Bad
public object RegisterUser(User user)
{
    // ...
    return json;
}
// Good
public UserRegistrationResult RegisterUser(User user)
{
    return new UserRegistrationResult
    {
        Success = true,
        UserId = 123,
        WelcomeDiscount = 10
    };
}

public class User
{
    // properties and methods of User class
}

public class UserRegistrationResult
{
    public bool Success { get; set; }
    public int UserId { get; set; }
    public int WelcomeDiscount { get; set; }
}
