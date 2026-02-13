public class Book
{
    public int Id { get; private set; }
    public string Title { get; private set; }
    public string Author { get; private set; }
    //public bool IsBorrowed{ get ; private set;}
    public int AvailableCopies{ get ; private set;}
    public Book(string title,string author, int totalCopies)
    {
        if(string.IsNullOrWhiteSpace(title))
            throw new ArgumentException("Title cannot be empty");

        if(string.IsNullOrWhiteSpace(author))
            throw new ArgumentException("Author cannot be empty");

        if (totalCopies <= 0)
        throw new ArgumentException("Total copies must be greater than zero");

        Title = title;
        Author = author;
        AvailableCopies = totalCopies;
    }
    public void BorrowCopy()
    {
        if (AvailableCopies <= 0)
            throw new InvalidOperationException("Book is not avivable.");

        AvailableCopies--;   
    }

    public void ReturnCopy()
    {
        AvailableCopies++;
    }
}