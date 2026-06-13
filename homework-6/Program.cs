/*1 DAVALEBA*/

/*int[][] students = [
    [10,20,30], 
    [20,30,40],
    [50,60,70],
    [80,90,100]
                 ];

foreach (var scores in  students)
{
    int sum = 0;
    foreach (var score in scores)
    {
        sum += score;
    }

    Console.WriteLine($"{sum/scores.Length}");
}*/

/*2 DAVALEBA*/
/*string guessNum = Console.ReadLine();
bool isRight = false;
string[] passcodes = new string[10];
for (var i = 0; i < passcodes.Length; i++)
{
    var randomInt = new Random().Next(1,5);
    var randomStr = randomInt.ToString();
    passcodes[i] = randomStr;
    if (guessNum == randomStr)
    {
        isRight = true;
    }
    
}
Console.WriteLine(isRight ? "GUESSED IT":"YOU LOST!");*/

/*3 DAVALEBA*/
/*int[] nums= [1,2,3,4,-4,-1,-10,100];
int min = nums[0];
int max = nums[0];
foreach (var element in nums)
{
    if (element < min)
    {
        min = element;
    }

    if (element > max)
    {
        max = element;
    }
}

Console.WriteLine($"min={min} max={max}");*/

/*4 DAVALEBA*/

/*string[] words = ["nika","luka","temuri","luka"];
foreach (var element in words)
{
    foreach (var symbol in element)
    {
        Console.WriteLine(symbol);
    }
    Console.WriteLine();
}*/
/*5 DAVALEBA*/
/*string[] emails = ["fafadfd@gmail.com","asfsafgmail.com","afasfFAfafasfa"];
foreach (var email in emails)
{
    bool includes = false;
    foreach (var symbol in email)
    {
        if (symbol == '@')
        {
            includes = true;
        }
    }

    Console.WriteLine(includes ? "IT INCLUDES @":"IT DOESN'T INCLUDES @");
}*/
Console.WriteLine("Hello");