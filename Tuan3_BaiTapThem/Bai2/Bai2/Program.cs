namespace Bai1
{
  class Program
  {
    static String str;
    // add chuoi
    public static void add()
    {
      System.Console.WriteLine("Nhap chuoi ma ban muon dao nguoc: ");
      str = Console.ReadLine();
    }
    // for dao nguoc chuoi
    public static void daoNguoc()
    {
      for (int i = str.Length - 1; i >= 0; i--)
      {
        System.Console.Write(str[i]);
      }
    }
    static void Main(string[] args)
    {
      add();
      daoNguoc();
    }
  }
}