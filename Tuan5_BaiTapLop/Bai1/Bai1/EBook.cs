using System.Security.AccessControl;

namespace Program;

public class EBook : Book
{
    private double FileSizeMB;

    public EBook(string id, string title, string author, int year, double fileSizeMb) : base(id, title, author, year)
    {
        FileSizeMB = fileSizeMb;
    }

    public double FileSizeMb
    {
        get => FileSizeMB;
        set => FileSizeMB = value;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("{FileSizeMB} MB ");
    }
}