﻿namespace JumpGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = new List<int>();
            Console.WriteLine(a);

            bool CanJump(int[] nums)
            {
                int lastPos = nums.Length - 1;
                for (int i = nums.Length - 1; i >= 0; i--)
                {
                    if (i + nums[i] >= lastPos)
                    {
                        lastPos = i;
                    }
                }

                return lastPos == 0;
            }
        }
    }
}
