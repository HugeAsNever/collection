// See https://aka.ms/new-console-template for more information
using System.Reflection.Emit;

int[] input = { 1, 3, 2 };
NextPermutation(input);
Console.WriteLine(input[1]);

void NextPermutation(int[] nums)
{
    var i = nums.Length - 2;
    while (i >= 0 && nums[i] >= nums[i + 1])
        i--;
    if (i >= 0)
    {
        var j = nums.Length - 1;
        while (nums[j] <= nums[i])
            j--;
        var temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
        Reverse(nums, i + 1);
    }
}

void Reverse(int[] nums, int start)
{
    int i = start, j = nums.Length - 1;
    while (i < j)
    {
        Swap(nums, i, j);
        i++;
        j--;
    }
}

void Swap(int[] nums, int i, int j)
{
    int temp = nums[i];
    nums[i] = nums[j];
    nums[j] = temp;
}