//// Naming intention
// Mal
string d = DateTime.Now.ToString("yyyy/MM/dd");
// bien
string currentDate = DateTime.Now.ToString("yyyy/MM/dd");

// Mal
void Save()
{
    // ...
}
// Bien
void SaveUserStatus()
{
    // ...
}

// Mal
string[] a = { "Ford", "Rena", "Citroen", "Mazda" };
foreach (var element in a)
{
    // ...
}
// Bien
string[] carMakers = { "Ford", "Rena", "Citroen", "Mazda" };
foreach (var maker in carMakers)
{
    // ...
}


