using System;

class Program
{
    // Hàm tính tổng các số chẵn trong mảng
    static int SumEvenNumbers(int[] array)
    {
        int sum = 0;
        foreach (int number in array)
        {
            if (number % 2 == 0) // Kiểm tra số chẵn
            {
                sum += number;
            }
        }
        return sum;
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

        // Tính tổng các số chẵn
        int result = SumEvenNumbers(array);

        // In kết quả
        Console.WriteLine($"Tong cac so chan trong mang la: {result}");
    }
}