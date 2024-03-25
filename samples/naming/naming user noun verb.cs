//// Naming use noun + verb in functions
// Bad
void Do(User u, Credentials c){
    // ...
}
// Good
void RegisterUser(User user, Credentials credentials){
    // ...
}

// Bad
void get(){
    // ....
}
// Good
void GetRegisteredUsers(){
    // ....
}


