

/*Console.WriteLine("Enter your name!");
var name = Console.ReadLine();
Console.WriteLine("Enter your password");
string password = Console.ReadLine();
if (name == "admin" && password == "1234")
{
    Console.WriteLine("welcome back!");
}
else if (name == "admin" && password != "1234" || name != "admin" && password == "1234" )
{
    Console.WriteLine("some of your parametres are wrong!");
}
else
{
    Console.WriteLine("you dont belong here");
}*/


/*
Console.WriteLine("Enter num1");
string numSTR = Console.ReadLine();
bool valid =  double.TryParse(numSTR, out double num1);
Console.WriteLine("what you want to do?");
string op = Console.ReadLine();
Console.WriteLine("Enter num2");
string numSTR2 = Console.ReadLine();
bool valid2 =  double.TryParse(numSTR2, out double num2);
if (valid && valid2)
{
    switch (op)
    {
        case "+":
            Console.WriteLine(num1 + num2);
            break;
        case "-":
            Console.WriteLine(num1 - num2);
            break;
        case "*" :
            Console.WriteLine(num1 * num2);
            break;
        case "/" :
            Console.WriteLine(num1 / num2);
            break;
        default:
            Console.WriteLine("Some of them is wrong!");
            break;
    } 
}
*/


/*Console.WriteLine("Enter your age");
string ageSTR = Console.ReadLine();
bool valid = byte.TryParse(ageSTR, out byte age);
if (valid)
{
    if (age >= 65)
    {
        Console.WriteLine("you are old");
    }else if (age >= 20)
    {
        Console.WriteLine("you are an adult");
    }else if (age >= 13)
    {
        Console.WriteLine("you are a teenager");
    }
    else
    {
        Console.WriteLine("you are a child");
    }
}
else
{
    Console.WriteLine("this is for humans,you are not a human");
}*/


Console.WriteLine("Done!");