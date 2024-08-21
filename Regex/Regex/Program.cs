// Create a pattern for a word that starts with the letter "M"
using System.Text.RegularExpressions;

string pattern = @"\b[M]\w+";
// Create a Regex
Regex rg = new Regex(pattern);
//ignore case
//Regex rg = new Regex(pattern, RegexOptions.IgnoreCase);

// Long string
string authors = "Mahesh Chand, Raj Kumar, Mike Gold, Allen O'Neill, Marshal Troll";
// Get all matches
MatchCollection matchedAuthors = rg.Matches(authors);
// Print all matched authors
for (int count = 0; count < matchedAuthors.Count; count++)
    Console.WriteLine(matchedAuthors[count].Value);

//split with non-decimal
string Text = "1 One, 2 Two, 3 Three is good.";

string[] digits = Regex.Split(Text, @"\D+");
var i = 1;

Console.WriteLine("Start");
foreach (string e in digits)
{
    Console.WriteLine($"{i}: {e}");
    i++;
}
Console.WriteLine("End");
Console.WriteLine(Text.Length);
Console.WriteLine(digits.Length);

foreach (string value in digits)
{
    int number;
    if (int.TryParse(value, out number))
    {
        Console.WriteLine(value);
    }
}