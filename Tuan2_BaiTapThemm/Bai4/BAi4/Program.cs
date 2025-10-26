using System;

class Program
{
    public static void SolveGameOver(string firstString, string findString, string insertString)
    {
        int isFinded = firstString.IndexOf(findString);

        if (isFinded != -1)
        {
            string resultString = firstString.Insert(isFinded, insertString + " ");
            Console.WriteLine(resultString);
        }
        else
        {
            Console.WriteLine("Không thể ghép từ - đoạn không tồn tại!");
        }
    }

    static void Main(string[] args)
    {
        string firstString = Console.ReadLine().Trim();
        string findString = Console.ReadLine().Trim();
        string insertString = Console.ReadLine().Trim();
        SolveGameOver(firstString, findString, insertString);
    }
}