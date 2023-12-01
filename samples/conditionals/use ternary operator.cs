//// Conditionals, assign using ternary operator
string message = "";

if (IsValid())
{
    validationOk = "Welcome!";
}
else
{
    validationOk = "Go Away";
}

// Bien
string validationOk = IsValid() ? "Welcome!" : "Go Away";
