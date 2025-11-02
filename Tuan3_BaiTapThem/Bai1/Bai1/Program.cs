namespace Bai1
{
  class Program
  {
    String str = "";
    Stack<char> stacks = new Stack<char>();

    public void addString()
    {
      System.Console.WriteLine("Nhap chuoi: ");
      str = Console.ReadLine();
    }

    public Boolean checkString()
    {
      bool flag = true;
      foreach (char kyTu in str)
      {
        if (kyTu == '(' || kyTu == '[' || kyTu == '{')
        {
          stacks.Push(kyTu);
        }
        else if (kyTu == ')' || kyTu == ']' || kyTu == '}')
        {
          if (stacks.Count == 0)
          {
            flag = false;
            break;
          }
          char mo = stacks.Pop();
          if ((kyTu == ')' && mo != '(') ||
                    (kyTu == ']' && mo != '[') ||
                    (kyTu == '}' && mo != '{'))
          {
            flag = false;
            break;
          }
        }
      }
      if (stacks.Count > 0)
      {
        flag = false;
      }
      return flag;
    }

    static void Main(string[] args)
    {
      Program p = new Program();
      p.addString();
      if (p.checkString())
      {
        System.Console.WriteLine("ok");
      }
      else
      {
        System.Console.WriteLine("NUNU");
      }

    }
  }
}