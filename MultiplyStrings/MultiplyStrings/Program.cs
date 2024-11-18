using System.Text;

namespace MultiplyStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num1 = "345345435435435";
            var num2 = "66587695434";
      
            Console.WriteLine(Multiply(num1, num2));


            string Multiply(string num1, string num2)
            {
                if (num1.Equals("0") || num2.Equals("0"))
                {
                    return "0";
                }
                var number1 = num1.ToCharArray().Reverse().ToArray();
                var number2 = num2.ToCharArray().Reverse().ToArray();
                //initial result array
                int[] result = new int[number1.Length + number2.Length];
                for (int p2 = 0; p2 < number2.Length; p2++)
                {
                    int digit2 = number2[p2] - '0';
                    for (int p1 = 0; p1 < number1.Length; p1++)
                    {
                        int digit1 = number1[p1] - '0';
                        var numZero = p1 + p2;
                        var prod = digit2 * digit1 + result[numZero];
                        result[numZero] = prod % 10;
                        result[numZero + 1] += prod / 10;
                    }
                }
                Array.Reverse(result);
                var resultStr = string.Join("", result);
                if (resultStr[0] == '0')
                    resultStr = resultStr.Substring(1, resultStr.Length - 1);
                return resultStr;
            }
        }
    }
}
