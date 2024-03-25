//// Conditionals, avoid arrow code
// MAL
string result = "";

if (!user.IsRegistered())
{
    if (user.Name.Length < 3)
    {
        result = "the name is too short";
    }
    else
    {
        if (user.Password.Length < 4)
        {
            result = "the password is too short";
        }
        else
        {
            if (user.Age < 18)
            {
                result = "you must be over 18 in order to register my friend";
            }
            else
            {
                if (user.Gender == "")
                {
                    result = "A gender must be specified";
                }
                else
                {
                    if (user.Country == "")
                    {
                        result = "Please select a country from the list";
                    }
                    else
                    {
                        if (user.HasValidEmail())
                        {
                            result = "Welcome man";
                        }
                        else
                        {
                            result = "The email is not valid";
                        }
                    }
                }
            }
        }
    }
}
else
{
    result = "This user is already registered";
}

return result;

// Bien - guard clauses
if (user.IsRegistered())
    return "This user is already registered";

if (user.Name.Length < 3)
    return "The name is too short";

if (user.Password.Length < 4)
    return "the password is too short";

if (user.Age < 18)
    return "you must be over 18 in order to register my friend";

if (user.Gender == "")
    return "A gender must be specified";

if (user.Country == "")
    return "Please select a country from the list";

if (!user.HasValidEmail())
    return "The email is not valid";

return "Welcome man";