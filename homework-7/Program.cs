/*1 DAVALEBA

string xStr = Console.ReadLine();
string yStr = Console.ReadLine();
bool isValidX = int.TryParse(xStr, out int x);
bool isValidY = int.TryParse(yStr, out int y);

void power(int x, int y)
{

    Console.WriteLine((int)Math.Pow(x, y));
};
if (isValidX && isValidY)
{
    power(x,y);
}
else
{
    Console.WriteLine("Invalid Input");
}*/

/*2 DAVALEBA*/
/*bool isPrime = false;
string numberStr = Console.ReadLine();
bool isNumber = int.TryParse(numberStr, out int number);
int counter = 0;
void guessTypeOfNum(int num)
{
    for (var i = 1; i <= num; i++)
    {
        if (num % i == 0)
        {
            counter++;
        }
    }

    if (counter == 2)
    {
        isPrime = true;
        Console.WriteLine($"{num} is prime number");
    }
    else
    {
        Console.WriteLine($"{num} is complex number");
    }
    
}

guessTypeOfNum(number);*/

/*3 DAVALEBA
string word = Console.ReadLine();
void CheckPalindrome(string word)
{
    string reversed = "";
    for (var i = word.Length - 1; i >= 0; i--)
    {
        reversed += word[i];
    }

    if (reversed == word)
    {
        Console.WriteLine($"{reversed} is a palindrome.");
    }else{
        Console.WriteLine($"{word} is not a palindrome.");
    }
}

CheckPalindrome(word);*/


/*4 DAVALEBA
string numberStr = Console.ReadLine();
bool isValid = int.TryParse(numberStr, out int number);

void ConvertToBinary(int number)
{

        string result = "";
        while (number > 0)
        {
            result = (number % 2) + result;
            number /= 2;
        }

        Console.WriteLine(result);
    };

if (isValid)
{
    ConvertToBinary(number);
}else{
    Console.WriteLine("Invalid input");
}*/

/*5 DAVALEBA
string xStr = Console.ReadLine();
string yStr = Console.ReadLine();
bool isValidX = int.TryParse(xStr, out int x);
bool isValidY = int.TryParse(yStr, out int y);

void power(int x, int y)
{

    Console.WriteLine((int)Math.Pow(x, y));
};
if (isValidX && isValidY)
{
    power(x,y);
}
else
{
    Console.WriteLine("Invalid Input");
}*/
Console.WriteLine("Hello, World!");

