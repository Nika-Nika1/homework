/*1 DAVALEBA*/
/*int[] nums1= [1,2,3,4,5,6,7,8,9];
int[] nums2= [5,6,7,8,9];
int[] fullNums = new int[nums1.Length + nums2.Length];
for (var i = 0; i < nums1.Length; i++)
{
    fullNums[i] = nums1[i];

}

for (var i = 0; i < nums2.Length; i++)
{
    fullNums[nums1.Length + i] = nums2[i];

}

foreach (var item in fullNums)
{
    Console.WriteLine(item);
}*/
/*2 Davaleba*/
/*int count = 0;
int[] nums = [1,2,3,4,5,6,7,8,9,10,-1,-2,-3,-4,-5,-6,-7,-8,-9,-10];
bool isValid = int.TryParse(Console.ReadLine(), out int targetNum);
if (isValid)
{
    for (int i = 0; i < nums.Length - 1; i++)
    {
        for (var j = i+1; j < nums.Length; j++)
        {
       
            for (var k = j + 1; k < nums.Length; k++)
            {
                if (nums[i] + nums[j] + nums[k] == targetNum)
                {
                    count++;
                    
                }
            }
        }
    }
    int[][] resultarray = new int[count][];
    int index = 0;
    for (int i = 0; i < nums.Length - 1; i++)
    {
        for (var j = i+1; j < nums.Length; j++)
        {
       
            for (var k = j + 1; k < nums.Length; k++)
            {
                if (nums[i] + nums[j] + nums[k] == targetNum)
                {
                    resultarray[index] = [nums[i], nums[j], nums[k]];
                    index++;
                }
            }
            
        }
    }
    foreach (var item in resultarray)
    {
        Console.WriteLine($"[{item[0]}, {item[1]}, {item[2]}]");
                
    }
    
}
else
{
    Console.WriteLine("Invalid input");
}*/
