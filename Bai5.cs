        // Nhập số thứ nhất
        Console.Write("Nhap so thu nhat: ");
        double number1 = Convert.ToDouble(Console.ReadLine());

        // Nhập số thứ hai
        Console.Write("Nhap so thu hai: ");
        double number2 = Convert.ToDouble(Console.ReadLine());

        // Tính tổng
        double sum = number1 + number2;

        // Tính tích
        double product = number1 * number2;

        // In kết quả
        Console.WriteLine($"Tong cua {number1} va {number2} la: {sum}");
        Console.WriteLine($"Tich cua {number1} va {number2} la: {product}");
