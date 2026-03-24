// Exercise 4
int[] numbers = { 10, 0 };
try
{
    int result = numbers[0] / numbers[2];
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine(ex.Message);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine(ex.Message);
}

catch (Exception ex)
{
    Console.WriteLine("Something went wrong");
}


// Exercise 3
/*
try
{
    int number = 0;
    int result = 20 / number;
}
catch (DivideByZeroException ex)
{
    Console.WriteLine(ex.Message);
}


// Exercise 2
Console.WriteLine("Write a number");
string input = Console.ReadLine();
try
{
 int number = int.Parse(input);
 Console.WriteLine("You wrote " + number);
}
catch (Exception ex)
{
    Console.WriteLine("Wrong: " + ex.Message);
}
       



// Exercise 1
try
{
    int number = int.Parse("Hej");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
*/