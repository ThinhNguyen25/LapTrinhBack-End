        // Nhập nhiệt độ độ C
        Console.Write("Nhap nhiet do (do C): ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        // Chuyển đổi sang độ F
        double fahrenheit = (celsius * 9 / 5) + 32;

        // In kết quả
        Console.WriteLine($"{celsius} do C = {fahrenheit} do F");
