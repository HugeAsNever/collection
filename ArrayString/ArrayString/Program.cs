using System.Linq;

namespace ArrayString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input1 = "pwwkew";
            Console.WriteLine(LengthOfLongestSubstring(input1));

   
            int LengthOfLongestSubstring(string s)
            {
                var maxCount = 0;
                for (var i = 0; i < s.Length; i++)
                {
                    var subStr = "";
                    for ( var j = 0; j < s.Length - i; j++)
                    {
                        if (!subStr.Contains(s[i+j]))
                        {
                            subStr += s[i+j];
                        }
                        else
                        {
                           j = s.Length;
                        }
                    }
                    if (maxCount < subStr.Length)
                    {
                        maxCount = subStr.Length;
                    }
                }
                return maxCount;            
            }
        
        }
    }
}
