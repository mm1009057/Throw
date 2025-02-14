using ThrowingEx;

string username = "Mason";
string password = "12345";

try
{
    Console.Write("Enter Username>>");
    string usernameInput = Console.ReadLine();
    Console.Write("Enter Password>>");
    string passwordInput = Console.ReadLine();
    
    //Vaidate length
    if (usernameInput.Length < 4)
    {
        throw new IndexOutOfRangeException("Enter a username with 4 characters or longer");
    }
    if (passwordInput.Length < 4)
    {
        throw new IndexOutOfRangeException("Enter a password with 4 characters or longer");
    }
    //Custom exceptions
    if (usernameInput != username)
    {
        throw new InvalidUsernameException(usernameInput, username);
    }
    if (passwordInput != password)
    {
        throw new InvalidPasswordException(passwordInput, password);
    }
    //final check user and pass
    if (usernameInput == username && passwordInput == password)
    {
        Console.WriteLine("Accsess Granted");
    }
}
catch (NullReferenceException)
{
    Console.WriteLine("Please supply inputs");
}
catch (FormatException)
{
    Console.WriteLine("Must use valid characters");
}
//custom excpetion catches
catch (InvalidUsernameException ex)
{
    Console.WriteLine(ex.Message);
}
catch (InvalidPasswordException ex)
{
    Console.WriteLine(ex.Message);
}
//catch all error handle
catch (IOException e)
{
    Console.WriteLine($"Error occured: {e}");
}

//https://www.youtube.com/watch?v=z1aLgRGNMgQ