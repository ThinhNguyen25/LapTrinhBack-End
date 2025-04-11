//Bai1
// Nhập tên
Console.Write("Nhap ten cua ban: ");
string name = Console.ReadLine();

// Nhập tuổi
Console.Write("Nhap tuoi cua ban: ");
int age = Convert.ToInt32(Console.ReadLine());

// In ra thông báo
Console.WriteLine($"Xin chao {name}, ban {age} tuoi!");


//Bai2
// Nhập chiều dài
Console.Write("Nhap chieu dai cua hinh chu nhat: ");
double length = Convert.ToDouble(Console.ReadLine());

// Nhập chiều rộng
Console.Write("Nhap chieu rong cua hinh chu nhat: ");
double width = Convert.ToDouble(Console.ReadLine());

// Tính diện tích
double area = length * width;

// In kết quả
Console.WriteLine($"Dien tich hinh chu nhat la: {area}");


//Bai3
// Nhập nhiệt độ độ C
Console.Write("Nhap nhiet do (do C): ");
double celsius = Convert.ToDouble(Console.ReadLine());

// Chuyển đổi sang độ F
double fahrenheit = (celsius * 9 / 5) + 32;

// In kết quả
Console.WriteLine($"{celsius} do C = {fahrenheit} do F");


//Bai4
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


//Bai5
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


//Bai6
// Nhập số
Console.Write("Nhap mot so: ");
double numberrr = Convert.ToDouble(Console.ReadLine());

// Kiểm tra số dương, âm hay bằng 0
if (numberrr > 0)
{
    Console.WriteLine($"{numberrr} la so duong.");
}
else if (numberrr < 0)
{
    Console.WriteLine($"{numberrr} la so am.");
}
else
{
    Console.WriteLine($"{numberrr} la so khong.");
}


//Bai7
// Nhập năm
Console.Write("Nhap mot nam: ");
int year = Convert.ToInt32(Console.ReadLine());

// Kiểm tra năm nhuận
bool isLeapYear = false;

if (year % 4 == 0)
{
    if (year % 100 == 0)
    {
        if (year % 400 == 0)
        {
            isLeapYear = true;
        }
    }
    else
    {
        isLeapYear = true;
    }
}

// In kết quả
if (isLeapYear)
{
    Console.WriteLine($"{year} la nam nhuan.");
}
else
{
    Console.WriteLine($"{year} khong phai la nam nhuan.");
}


//Bai8
// In bảng cửu chương từ 1 đến 10
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"Bang cuu chuong {i}:");
    for (int j = 1; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine(); // Dòng trống để phân cách giữa các bảng
}


//Bai9
// Nhập số nguyên dương
Console.Write("Nhap mot so nguyen duong n: ");
int n = Convert.ToInt32(Console.ReadLine());

// Kiểm tra số nhập vào có phải là số nguyên dương
if (n < 0)
{
    Console.WriteLine("Vui long nhap mot so nguyen duong!");
    return;
}

// Tính giai thừa
long factorial = 1;
for (int i = 1; i <= n; i++)
{
    factorial *= i;
}

// In kết quả
Console.WriteLine($"Giai thua cua {n} la: {factorial}");


//Bai10
// Nhập số nguyên
Console.Write("Nhap mot so nguyen: ");
int numberr = Convert.ToInt32(Console.ReadLine());

// Kiểm tra số nguyên tố
bool isPrime = true;

// Số nhỏ hơn 2 không phải là số nguyên tố
if (numberr < 2)
{
    isPrime = false;
}
else
{
    // Kiểm tra từ 2 đến căn bậc hai của number
    for (int i = 2; i <= Math.Sqrt(numberr); i++)
    {
        if (numberr % i == 0)
        {
            isPrime = false;
            break;
        }
    }
}

// In kết quả
if (isPrime)
{
    Console.WriteLine($"{numberr} la so nguyen to.");
}
else
{
    Console.WriteLine($"{numberr} khong phai la so nguyen to.");
}