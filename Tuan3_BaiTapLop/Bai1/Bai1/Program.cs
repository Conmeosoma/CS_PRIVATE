using System.Collections;

namespace Program;


public class Program
{
    // Collection la cac cau truc du lieu duoc su dung
    // de luu tru va quan ly tap hop cac doi tuong
    // - Ưu điểm quản lý dữ liệu nhanh hơn mảng, hỗ trợ nhiều phương  thức và tính năng sẫn có hơn

    // Generic Conllection: Cho phép làm việc với các kiểu dữ liệu cụ thể (List<T>, Dictionary<Tkey,TValue.).
    // Non _ Genneric Conllection : Làm việc vs kiểu dư liệu không cụ thể, thường là object(ArrayList,HashTable,....)

    // tai sao su dung Generic Collection : Tránh lỗi runtime do kiểu dữ liệu không khớp,tăng tính an toàn về kiểu dữ liệu,hiệu suất tốt hơn do tránh boxing/unboxing.
    // boxing : Chuyển 1 kiểu dữ liệu giá trị thành kiểu dữ liệu tham chiếu
    // unboxing : Chuyển 1 kiểu dữ liệu tham chiếu thành kiểu value



    public static void Main(string[] args)
    {
        // Collection - List<T>
        List<int> numbers = new List<int>{1,2,3,4,5
        };
        numbers.Add(6);
        System.Console.WriteLine(String.Join(", ", numbers));
        // chuyên dãy có dấu phẩy ngăn cách

        // Dictionary<TKey,TValue>
        Dictionary<String, int> studentScores = new Dictionary<string, int>()
        {
            {
                "Alice", 90},{ "Bob", 85}
        };

        System.Console.WriteLine(studentScores["Alice"]);




        ArrayList arrayList = new ArrayList();
        arrayList.Add(1);
        arrayList.Add(2);
        arrayList.Add("Three"); // Cho phép thêm các kiểu dữ liệu khác nhau
        foreach (var item in arrayList)
        {
            System.Console.WriteLine(item);
        }




        // Hashtable hashtable = new Hashtable();
        // hashtable["One"] = 1;
        // hashtable["Two"] = 2;
        // hashtable["Three"] = 3;
        // foreach (Hashtable hashtable1 in hashtable.Keys)
        // {
        //     System.Console.WriteLine($"{hashtable1} : {hashtable[hashtable1]}");
        // }



        SortedList sortedList = new SortedList();
        sortedList.Add(3, "Three");
        sortedList.Add(1, "One");
        sortedList.Add(2, "Two");
        foreach (var key in sortedList.Keys)
        {
            System.Console.WriteLine(sortedList[key]);
        }




        Stack stack = new Stack();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        foreach (var item in stack)
        {
            System.Console.WriteLine(item);
        }


        Queue queue = new Queue();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        foreach (var item in queue)
        {
            System.Console.WriteLine(item);
        }



        BitArray bitArray = new BitArray(8);
        bitArray.Set(0, true);
        bitArray.Set(3, true);
        bitArray.Set(5, true);
        for (int i = 0; i < bitArray.Count; i++)
        {
            System.Console.WriteLine(bitArray.Get(i));
        }



        //struct
        SinhVien sv = new SinhVien("Nguyen Van A", 20);
        sv.showInfo();

    }
    struct SinhVien
    {
        public string Name;
        public int Age;
        public SinhVien(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void showInfo()
        {
            System.Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}

