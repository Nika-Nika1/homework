
/*1 DAVALEBA*/

/*string num1Str = Console.ReadLine();
bool isValid = int.TryParse(num1Str, out int num1);
if (isValid)
{
    for (var i = 1; i < 11; i++)
    {
        Console.WriteLine($"{num1} * {i} = " + (num1 * i));
    }
}*/

/*2 DAVALEBA*/
/*
string numStr = Console.ReadLine();
bool isValid = int.TryParse(numStr, out int num1);
if (isValid)
{
    for (var i = 1; i <= num1; i++)
    {
        for (var j = 0; j <= num1 -i; j++)
        {   
            Console.Write(" ");
            
        
        }

        for (var s = 0; s < i; s++)
        {
            Console.Write("* ");
        }
        Console.WriteLine();
    }
}
*/

/*3 DAVALEBA*/
/*string numStr = Console.ReadLine();
bool isValid = int.TryParse(numStr, out int num1);
if (isValid)
{
    var sum = 0;
    for (var i = 1; i <= num1; i++)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine("odd is "+ i);
            sum += i;
        }
    
    } 
    Console.WriteLine("Total of odds is - " + sum);

}*/
/*4 Davaleba*/

/*
var random = new Random();
var randomNum = random.Next(1, 10);
int num;
Console.WriteLine("Enter a number between 1 and 10");
do
{

    string guessNumStr = Console.ReadLine();
    if (guessNumStr.Length > 1)
    {
        Console.WriteLine("WE NEED SINGLE DIGIT NUMBER!!");
    }
    bool isValid = int.TryParse(guessNumStr, out num);
    if (isValid && num != randomNum)
    {
        Console.WriteLine("WRONG NUMBER!");
    }

    if (!isValid)
    {
        Console.WriteLine("ENTER VALID NUMBER!");
    }

} while (num != randomNum);
Console.WriteLine("You guessed it!!");
*/

Console.WriteLine("Hello");