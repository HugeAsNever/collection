using System.Collections;

namespace OddEvenJump
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 1, 1, 4 };

            //var result = 0;
            List<int> arrList = arr.ToList();
            //for (var i = 0; i < arr.Length; i++)
            //{
            //    var position = i;
            //    int jump = 1;
            //    if (position == arrList.Count - 1)
            //    {
            //        result++;
            //    }
            //    else
            //    {
            //        bool isContinue = true;
            //        while (isContinue)
            //        {
            //            var remains = arrList.GetRange(position + 1, arrList.Count - position - 1);
            //            if (jump % 2 == 0)
            //            {
            //                var temp = remains.Where(x => x <= arrList[position]).ToList();
            //                if (temp != null && temp.Count > 0)
            //                {
            //                    position += remains.IndexOf(temp.Max()) + 1;
            //                }
            //                else
            //                {
            //                    isContinue = false;
            //                }
            //            }
            //            else
            //            {
            //                var temp = remains.Where(x => x >= arrList[position]).ToList();
            //                if (temp != null && temp.Count > 0)
            //                {
            //                    position += remains.IndexOf(temp.Min()) + 1;
            //                }
            //                else
            //                {
            //                    isContinue = false;
            //                }
            //            }
            //            if (position == arrList.Count - 1)
            //            {
            //                result++;
            //                isContinue = false;
            //            }
            //            jump++;
            //        }
            //    }
            //}
            //Console.WriteLine(result);

            SortedList<int,int> sl = new SortedList<int, int>();
            var success = 0;
            for (int i=0; i < arrList.Count; i++)
            {
                sl.Add(i, arrList[i]);
            }
            var slOdd = sl.OrderBy(x => x.Value).ThenBy(x => x.Key);
            var slEven = sl.OrderByDescending(x => x.Value).ThenBy(X => X.Key);
            for (int j=0; j < arrList.Count; j++)
            {
                bool go = true;
                var step = 1;
                var current = arrList[j];
                var position = j;
                while (go)
                {
                    if (position == arrList.Count - 1)
                    {
                        success++;
                        go = false;
                    }
                    else
                    {
                        KeyValuePair<int, int> a;
                        if(step % 2 == 0)
                        {
                            a = slEven.FirstOrDefault(x => x.Value <= current && x.Key > position, new KeyValuePair<int,int>(-1,-1));
                           
                        }
                        else
                        {
                            a = slOdd.FirstOrDefault(x => x.Value >= current && x.Key > position, new KeyValuePair<int, int>(-1, -1));
                        }

                        if (a.Key != -1)
                        {
                            position = a.Key;
                            current = a.Value;
                        }
                        else
                        {
                            go = false;
                        }
                    }
                    step++;
                }
            }
            Console.WriteLine(success);

        }



    }
}
