

Console.Write("Please create a username: ");
string CreatedUsername = Console.ReadLine();    //user is asked to create a username.
                                                //username is stored in a variable.
                                                //nullable variable so that input can be null and login details can still be correct

Console.Write("Please create a password: ");
string CreatedPassword = Console.ReadLine();

Console.Write("Please enter your usernname: "); //user is asked to enter their username
string username = Console.ReadLine();

Console.Write("Please enter your password: ");
string password = Console.ReadLine();

//if (username && password == true)
if (CreatedUsername == username && CreatedPassword == password) { //if the username and password entered matches what they created, log in.

        Console.WriteLine("You have successfully logged in!");
 
} else {
        Console.WriteLine("Login details are incorrect!"); //if the username and password entered doesn't matche what they created, error message.
}
