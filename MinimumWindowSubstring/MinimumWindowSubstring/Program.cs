namespace MinimumWindowSubstring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = "haha";
            var b=a.IndexOf("c");
            var c = a.Remove(0,1);
            Console.WriteLine(b);
            public string MinWindow(string s, string t)
            {
                var minLgh = s.Length;
                var result = "";
                var i = 0;
                var j = 0;
                while (i + j < s.Length)
                {
                    var str = s.Substring(i, j - i + 1);
                    if (!CheckExist(str, t))
                    {
                        j++;
                    }
                    else
                    {
                        while (i < j && CheckExist(str, t))
                        {
                            i++;
                            str = s.Substring(i, j - i + 1);
                        }
                        i--;
                        str = s.Substring(i, j - i + 1);
                        if (str.Length < minLgh)
                        {
                            result = str;
                            minLgh = str.Length;
                        }
                    }
                    i++;
                }
                return result;
            }

            public bool CheckExist(string sourceString, string checkString)
            {
                foreach (var letter in checkString)
                {
                    var i = sourceString.IndexOf(letter);
                    if (i >= 0)
                    {
                        sourceString = sourceString.Remove(i, 1);
                    }
                    else
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
