namespace RotateImage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            void Rotate(int[][] matrix)
            {
                var square = matrix.ToList();
                for (var i = 0; i < matrix[0].Length; i++)
                {
                    var row = new List<int>();
                    for (var j = matrix.Length - 1; j >= 0; j--)
                    {
                        row.Add(square[j][i]);
                    }
                    matrix[i] = row.ToArray();
                }
            }
        }
    }
}
