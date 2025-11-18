namespace Program;

public class Program
{
    
    public static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }
    
    public static void Main(string[] args)
    {
        int a = 10;
        int b = 15;
        // Dog dog1 = new Dog();
        // dog1.makeSound();
        // Swap(ref a,ref b);
        Swap(ref a,ref b);
        Console.WriteLine(a);
        Console.WriteLine(b);
        
    }
}