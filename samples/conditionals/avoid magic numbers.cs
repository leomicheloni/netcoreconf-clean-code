//// Conditionals, don't use magic numbers
// Mal
if(user.age > 18){
    // ...
}
// Bien
int validAge = 18;
if(user.age > validAge){
    // ...
}

// Mal
Thread.Sleep(86400000);
// Bien
const int MILLISECONDS_IN_A_DAY = 86400000;
Thread.Sleep(MILLISECONDS_IN_A_DAY);

// Mal
if(userStatus == -1){ // new user
    // ....
}
// Bien
int UserStatusNew = -1;
if(userStatus == UserStatusNew){
    // ....
}

