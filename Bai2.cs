using System;

class Program
{
    // Hàm kiểm tra số nguy hiểm (tất cả các chữ số giống nhau)
    static bool IsDangerousNumber(int number)
    {
        // Chuyển số thành chuỗi để dễ kiểm tra các chữ số
        string numStr = Math.Abs(number).ToString();

        // Nếu số chỉ có 1 chữ số, không coi là số nguy hiểm
        if (numStr.Length == 1) return false;

        // Lấy chữ số đầu tiên
        char firstDigit = numStr[0];

        // Kiểm tra các chữ số còn lại
        for (int i = 1; i < numStr.Length; i++)
        {
            if (numStr[i] != firstDigit)
            {
                return false;
            }
        }
        return true;
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

        // Kiểm tra và in ra các số nguy hiểm
        Console.WriteLine("Cac so nguy hiem trong mang:");
        bool found = false;
        for (int i = 0; i < n; i++)
        {
            if (IsDangerousNumber(array[i]))
            {
                Console.WriteLine($"Chi so: {i}, Gia tri: {array[i]}");
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("Khong co so nguy hiem trong mang.");
        }
    }
}