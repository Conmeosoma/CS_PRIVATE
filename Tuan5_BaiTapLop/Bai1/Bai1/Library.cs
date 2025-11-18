namespace Program;

public class Library
{
    private List<IBook> books = new List<IBook>();

    public void AddBook(IBook book)
    {
        books.Add(book);
    }

    public void RemoveBook(IBook book)
    {
        books.Remove(book);
    }
    public List<IBook> GetAll()
    {
        return books;
    }

    public void PrintInventory()
    {
        foreach (var b in books)
        {
            b.DisplayInfo();
        }
    }

    public void PrintInventory(string author)
    {
        for (int i = 0; i < books.Count(); i++)
        {
            if (books[i].Author.Equals(author,StringComparison.OrdinalIgnoreCase))
            {
                books[i].DisplayInfo();
            }
        }
    }

    public List<IBook> FinaByAnthor(String author)
    {
        List<IBook> resutl = new List<IBook>();
        for (int i = 0; i < books.Count(); i++)
        {
            if (books[i].Author.Equals(author,StringComparison.OrdinalIgnoreCase))
            {
                resutl.Add(books[i]);
            }
        }

        if (resutl.Count > 0)
        {
            Console.WriteLine("Cac tac gia la: ");
            foreach (var b in resutl)
            {
                b.DisplayInfo();
                
            }
        }

        return resutl;
    }

    public IBook GetNewestBook()
    {
        if (books.Count == 0)
        {
            return null;
        }

        IBook neww = books[0]; 

        for (int i = 1; i < books.Count; i++)
        {
            if (books[i].Year > neww.Year)
            {
                neww = books[i];
            }
        }

        return neww;
    }

    public int CountByYear(int year)
    {
        int dem = 0;
        for (int i = 0; i < books.Count(); i++)
        {
            if (books[i].Year == year)
            {
                dem++;
            }
        }

        return dem;
    }

    public Dictionary<string, int> CountByAuthor()
    {
        Dictionary<string, int> result = new Dictionary<string, int>();
        for (int i = 0; i < books.Count(); i++)
        {
            if (result.ContainsKey(books[i].Author))
            {
                result[books[i].Author]++;
            }
            else
            {
                result.Add(books[i].Author, 1);
            }
        }
        return result;
    }

}