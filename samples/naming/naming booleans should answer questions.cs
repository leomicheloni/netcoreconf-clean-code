// Naming, boolean should answer question
// Mal
public void Valid()
{
    // ...
}
// Bien
public void IsValidSubmission()
{
    // ...
}

// Mal
bool valid = true;
// Bien
bool isValid = true;

// Mal
bool registered = false;
// Bien
bool isRegistered = false;

// Mal
bool notValid = false;
// Bien
bool isValid = true;



// don't double negate
// Mal
if (!notValid)
{
    // ...
}

// Bien
if (isValid)
{
    // ...
}
```
