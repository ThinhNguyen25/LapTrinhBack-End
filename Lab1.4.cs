using System.Collections;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using Lesson02;

internal class Program
{
    //4.1 định nghĩa Delegate
    //cú pháp mức độc truy cập public hoặc private + Delegate + kiểu dữ liệu + tên Delegate(Tham số)
    //Kiểu trả về của tham số Delegate phải trùng với phương thức muốn tham chiếu
    public delegate int MyDelegate(int a, int b);
    private static int tong(int x, int y)
    {
        return x + y;
    }
    private static void ShowArrayList(ArrayList List)
    {
        //1.1.4 Duyệt ArrayList 
        //Cách 1 dùng for
        //for (int i = 0;i < List.Count; i++)
        //{
        //    Console.WriteLine(List[i]);
        //}
        //Cách 2 dùng Enumerator
        //IEnumerator enumerator = List.GetEnumerator();
        //while (enumerator.MoveNext())
        //{
        //    Console.WriteLine(enumerator.Current);
        //}
        //Cach 3: foreach lặp từng phần tử 
        foreach (var Item in List)
        {
            Console.WriteLine(Item);
        }
    }
    private static void swap<T>(ref T var1, ref T var2)
    {
        T temp = var1;
        var1 = var2;
        var2 = temp;
    }
    private static async Task Main(string[] args)
    {
        /*
        //1. Collection
        //1.1 ArrayList
        //1.1.1 Khai báo và khởi tạo ArrayList

        ArrayList arrayList = new ArrayList();//Cách thứ nhất
        ArrayList array = new ArrayList()//Cách thứ hai
        {
            1, "CNTT 17-15 ", 3.14, true
        };
        //1.1.2 Truy xuất
        //Truy xuất các phần tử từ index từ 0
        Console.WriteLine($"array[0] = {array[0]}");
        Console.WriteLine($"array[1] = {array[1]}");
        Console.WriteLine($"array[2] = {array[2]}");
        //1.1.3 Thêm một phần tử vào ArrList 
        //Add.(object? value); Thêm giá trị vào cuối danh sách (collection)
        //Insert(int index(vitri), object? value); Chèn giá trị vào vị trí index 
        //AddRange(Icollection collection gì đấy) Thêm collection vào cuối danh sách 
        //InsertRange(int index, Icollection collection gì đấy); Chèn collection vào vị trí index 
        array.Add("New Item");
        Console.WriteLine("- After Add:");
        ShowArrayList(array);

        array.Insert(0, "Insert value");
        Console.WriteLine("- After Insert");
        ShowArrayList(array);

        arrayList.Add(1);
        arrayList.Add(2);
        arrayList.Add(3);
        //arrayList = [1,2,3]
        array.AddRange(arrayList);
        Console.WriteLine("- After AddRange");
        ShowArrayList(array);

        array.InsertRange(0, arrayList);
        Console.WriteLine("- After InsertRange");
        ShowArrayList(array);

        //1.1.5 Xóa phần tử 
        //Remove(value): Tim den phan tu co gia tri = value xoa khoi danh sach
        //RemoveAt(int index): xoa phan tu tai vi tri index
        //RemoveRange(int index, int count): Xoa count phan tu bat dau tu vi tri index
        //Clear(): Xoa het
        array.Remove(3.14);
        Console.WriteLine("- After Remove");
        ShowArrayList(array);

        array.RemoveAt(0);
        Console.WriteLine("- After RemoveAT");
        ShowArrayList(array);

        array.RemoveRange(0, 3);
        Console.WriteLine("- After RemoveRange");
        ShowArrayList(array);

        array.Clear();
        Console.WriteLine("- After Clear");
        ShowArrayList(array);
        //1.2 Hashtable 
        //- Lưu trữ các phần tử dưới dạng key-value pairs [key,value]
        //- key là duy nhất
        Hashtable ht = new Hashtable();
        ht.Add(17710206502, "A");
        ht.Add(1771020650, "N");
        ht.Add(17710206504, "D");
        //Xóa phần tử: xóa theo key
        ht.Remove(17710206502);
        //Duyệt Hashtable
        foreach(object o in ht.Values)
        {
            Console.WriteLine(o);
        }
        //Truy xuất đến giá của các phần tử thông qua key
        Console.WriteLine("[17710206502] = " + ht[17710206502]);
        Console.WriteLine("[1771020650] = " + ht[1771020650]);
        //1.3 SortedList 
        //Giong Hashtble nhung duoc tu sap xep cac phan tu theo key
        //Truy xuat den cac phan tu co the thong qua ca key va index

        //2.Generics
        //Generics la mot kieu du lieu dai dien khi nao code duọc thuc thi thì mới cần public kiểu dữ liệu cụ thể 
        //2.1 lớp Generics
        //Khai bao va khoi tao doi tuong
        ClassGeneric<int, double> ClassInt = new ClassGeneric<int, double>(1, 2.2);
        //ClassGeneric<Double> ClassDouble = new ClassGeneric<Double>(1.1, 2.2);
        //ClassGeneric<String> ClassString = new ClassGeneric<String>("a", "b");

        //2.2 phương thức Generics
        int a = 3;
        int b = 5;
        swap(ref a, ref b);

        double a1 = 3.3;
        double b1 = 5.5;
        swap(ref a1, ref b1);

        string a2 = "a";
        string b2 = "b";
        swap(ref a2, ref b2);
        //3. Generics collection 
        List<int> list = new List<int>();
        List<double> list2 = new List<double>();
        List<string> list3 = new List<string>();
        //4. Delagate
        //Delagate là một kiểu dữ liệu dùng để tham chiếu tới các phương thức trong c# (giống với con trỏ hàm trong C)
        // 3 bước sử dụng
        //- định nghĩa 
        //- khai báo và khởi tạo
        //- thực thi 
        //4.2 khai báo và khởi tạo
        MyDelegate mydelegate = new MyDelegate(tong);//cách một
        MyDelegate mydelegate2 = tong;//cách một
        //4.3 thực thi
        int result = mydelegate2(5, 5);
        Console.WriteLine($"Result = {result}");
        //Anonymous Method (phương thức ẩn danh)
        mydelegate = delegate (int x, int y)
        {
            return x + y;
        };
        //Lambda Expression =>
        mydelegate = (x, y) => x + y;
        //Trong c# cung cấp sẵn 3 loại delegate  
        //- Action: Bao bọc tất cả các phương thức có kiểu trả về là void
        //- Predicate: Bao bọc tất cả các phương thức có kiểu trả về là bool
        //- Func: Bao bọc tất cả các phương thức có kiểu trả về là int, double ,...
        Func<int, int, int> func = (x, y) => x + y;//int
        Predicate<int> predicate = x => x > 0;//bool
        Action<int> action = x => Console.WriteLine(x);//void
        */
        //5. Asynchronous Programming (Lập trình bất dồng bộ)
        Console.WriteLine("Main Method started... ");
        await SomeMethod();
        Task NhanTinVoiLan = SomeMethod();
        Task NhanTinVoiHoa = SomeMethod();
        //Thực hiện nhiều Task cùng 1 lúc thì dùng Task.When()
        await Task.WhenAll(NhanTinVoiLan, NhanTinVoiHoa);
        Console.WriteLine("Main Method end!");
        Console.ReadKey();
    }
    //public static async void SomeMethod()
    //{
    //    Console.WriteLine("Some Method started... ");
    //    //Thread.Sleep(5000);//Giả sử mất 5 giây để thưc hiện nhiệm vụ
    //    await Task.Delay(5000);//Delay 5 giây 
    //    Console.WriteLine("Some Method end!");
    //}
    public static async Task SomeMethod()
    {
        Console.WriteLine("Some Method started... ");
        //Thread.Sleep(5000);//Giả sử mất 5 giây để thưc hiện nhiệm vụ
        await Task.Delay(5000);//Delay 5 giây 
        Console.WriteLine("Some Method end!");
    }
}