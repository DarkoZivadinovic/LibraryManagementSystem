public class Book
{
    public int Id { get; private set; }

    public string Title { get; private set; }
    public string Author { get; private set; }
    public bool IsBorrowed { get; private set; }

    public Book(string title, string author)
    {
        if (string.IsNullOrWhiteSpace(title))
            throw new ArgumentException("Title cannot be empty");

        if (string.IsNullOrWhiteSpace(author))
            throw new ArgumentException("Author cannot be empty");

        Title = title;
        Author = author;
        IsBorrowed = false;
    }

    public void MarkAsBorrowed()
    {
        if (IsBorrowed)
            throw new InvalidOperationException("Book is already borrowed");

        IsBorrowed = true;
    }

    public void Return()
    {
        IsBorrowed = false;
    }
}