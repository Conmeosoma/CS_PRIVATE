namespace Tuan2
{
  class Tuan2
  {
    static double score;
    static void nhap()
    {
      System.Console.WriteLine("Nhap diem cua sinh vien: ");

      score = double.Parse(Console.ReadLine());

    }
    static void tinhToan()
    {
      if (score < 5)
      {
        System.Console.WriteLine("TB" + (int)score);
      }
      else if (5 <= score & score <= 7)
      {
        System.Console.WriteLine("Kha" + (int)score);
      }
      else
      {
        System.Console.WriteLine("Gioi" + (int)score);
      }
    }
    static void Main(string[] args)
    {
      nhap();
      tinhToan();
    }
  }
}