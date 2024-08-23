namespace FruitIntoBaskets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int TotalFruit(int[] fruits)
            {
                var fruitTypes = fruits.ToList().Distinct();
                var maxNumber = 0;
                var secondMaxNumber = 0;
                foreach (var type in fruitTypes)
                {
                    var fruitCount = fruits.Select(x => x == type).ToList().Count;
                    if (fruitCount > secondMaxNumber)
                    {
                        secondMaxNumber = fruitCount;
                    }
                    if (secondMaxNumber > maxNumber)
                    {
                        var temp = maxNumber;
                        maxNumber = secondMaxNumber;
                        secondMaxNumber = temp;
                    }
                }
                return maxNumber + secondMaxNumber;
            }
        }
    }
}
