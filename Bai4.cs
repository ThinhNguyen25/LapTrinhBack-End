        // Nhập số nguyên
        Console.Write("Nhap mot so nguyen: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Kiểm tra số chẵn
        if (number % 2 == 0)
        {
            Console.WriteLine($"{number} la so chan.");
        }
        else
        {
            Console.WriteLine($"{number} khong phai la so chan.");
        }