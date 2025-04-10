using System;

class Program
{
    // Hàm đếm số lượng số âm và số dương
    static void CountPositiveNegative(int[] array, out int positiveCount, out int negativeCount)
    {
        positiveCount = 0;
        negativeCount = 0;

        foreach (int number in array)
        {
            if (number > 0)
            {
                positiveCount++;
            }
            else if (number < 0)
            {
                negativeCount++;
            }
        }
    }

    static void Main(string[] args)
    {
        // Nhập số lượng phần tử của mảng
        Console.Write("Nhap so luong phan tu cua mang: ");
        int n = Convert.ToInt32(Console.ReadLine());

        // Khởi tạo mảng
        int[] array = new int[n];

        // Nhập các phần tử của mảng
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap phan tu thu {i + 1}: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Đếm số lượng số dương và số âm
        int positiveCount, negativeCount;
        CountPositiveNegative(array, out positiveCount, out negativeCount);

        // In kết quả
        Console.WriteLine($"So luong so duong trong mang: {positiveCount}");
        Console.WriteLine($"So luong so am trong mang: {negativeCount}");
    }
}