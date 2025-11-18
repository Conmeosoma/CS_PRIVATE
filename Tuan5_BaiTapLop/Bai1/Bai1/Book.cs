namespace Program;

public class Book : IBook
{
    public string Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }

    public Book(string id, string title, string author, int year)
    {
        Id = id;
        Title = title;
        Author = author;
        Year = year;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine("[Book] {Id} | \"{Title}\" - {Author} ({Year}), {Pages} pages");
    }
    
}