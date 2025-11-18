namespace Program;

public interface IBook
{
    string Id { get; set; }
    string Title { get; set; }
    string Author { get; set; }
    int Year { get; set; }
    
    public void DisplayInfo()
    {
       // Console.WriteLine("Id: " + Id + "Title: " + Title + "Author: " + Author + "Year: " + Year);
    }

}