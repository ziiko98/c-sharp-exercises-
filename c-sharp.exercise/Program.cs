using System;
    
// C# methods - 1
    Console.WriteLine("Enter your password");
    string password = Console.ReadLine();
    bool passwordMatch = CheckPassword(password);
    if (passwordMatch)
    {
        Console.WriteLine("Success");
    }
    else
    {
        Console.WriteLine("Login failed");
    }
    
    bool CheckPassword(string password)
    {
    return password.ToLower() == "pencil";
    }

