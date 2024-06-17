namespace FundamentalUpskilling;
public class Array
{
    public void Main()
    {
        int[] numbers = new int[5];
        numbers[0] = 10;
        numbers[1] = 20;
        numbers[2] = 30;
        numbers[3] = 40;

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        // multi dimension array
        int[,] matrix = new int[2, 2];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.WriteLine("isi matrix[" + i + "," + j + "]");
                Console.WriteLine(i + j);
                matrix[i, j] = i + j;
            }
        }

        Console.WriteLine(matrix[1, 0]);
    }

}