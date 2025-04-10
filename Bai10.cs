// Nhập số nguyên
Console.Write("Nhap mot so nguyen: ");
int number = Convert.ToInt32(Console.ReadLine());

// Kiểm tra số nguyên tố
bool isPrime = true;

// Số nhỏ hơn 2 không phải là số nguyên tố
if (number < 2)
{
    isPrime = false;
}
else
{
    // Kiểm tra từ 2 đến căn bậc hai của number
    for (int i = 2; i <= Math.Sqrt(number); i++)
    {
        if (number % i == 0)
        {
            isPrime = false;
            break;
        }
    }
}

// In kết quả
if (isPrime)
{
    Console.WriteLine($"{number} la so nguyen to.");
}
else
{
    Console.WriteLine($"{number} khong phai la so nguyen to.");
}