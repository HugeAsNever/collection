namespace FruitIntoBaskets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 1, 0, 1, 4, 1, 4, 1, 2, 3 };
            Console.WriteLine(TotalFruit(input));
            //v1
            //int TotalFruit(int[] fruits)
            //{
            //    var currentMaxCount = 0;
            //    var basket1 = new List<int>();
            //    var basket2 = new List<int>();
            //    var continueCount = 0;
            //    for (var i = 0; i < fruits.Length; i++)
            //    {
            //        basket1.Add(fruits[i]);
            //        continueCount++;
            //        if (i + 1 < fruits.Length)
            //        {
            //            if (fruits[i + 1] != basket1[0])
            //            {
            //                if (basket2.Count == 0 || fruits[i + 1] == basket2[0])
            //                {
            //                    var temp = basket1;
            //                    basket1 = basket2;
            //                    basket2 = temp;
            //                    continueCount = 0;
            //                }
            //                else
            //                {
            //                    var countNow = basket1.Count + basket2.Count;
            //                    if (currentMaxCount < countNow)
            //                    {
            //                        currentMaxCount = countNow;
            //                    }
            //                    basket2 = basket1.GetRange(0, continueCount); ;
            //                    basket1 = new List<int>();
            //                    continueCount = 0;
            //                }
            //            }
            //        }
            //        else
            //        {
            //            var countNow = basket1.Count + basket2.Count;
            //            if (currentMaxCount < countNow)
            //            {
            //                currentMaxCount = countNow;
            //            }
            //        }
            //    }
            //    return currentMaxCount;
            //}

            int TotalFruit(int[] fruits)
            {
                var currentMaxCount = 0;
                var basket1 = -1;
                var basket2 = -1;
                var basketCount1 = 0;
                var basketCount2 = 0;
                var continueCount = 0;
                for (var i = 0; i < fruits.Length; i++)
                {
                    basketCount1++;
                    continueCount++;
                    basket1 = fruits[i];
                    if (i + 1 < fruits.Length)
                    {
                        if (fruits[i + 1] != basket1)
                        {
                            if (basket2 == -1 || fruits[i + 1] == basket2)
                            {
                                var temp = basket1;
                                basket1 = basket2;
                                basket2 = temp;
                                temp = basketCount1;
                                basketCount1 = basketCount2;
                                basketCount2 = temp;
                                continueCount = 0;
                            }
                            else
                            {
                                var countNow = basketCount1 + basketCount2;
                                if (currentMaxCount < countNow)
                                {
                                    currentMaxCount = countNow;
                                }
                                basket2 = basket1;
                                basket1 = fruits[i + 1];
                                basketCount2 = continueCount;
                                basketCount1 = 0;
                                continueCount = 0;
                            }
                        }
                    }
                    else
                    {
                        var countNow = basketCount1 + basketCount2;
                        if (currentMaxCount < countNow)
                        {
                            currentMaxCount = countNow;
                        }
                    }
                }
                return currentMaxCount;
            }
        }
    }
}
