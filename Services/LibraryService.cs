public class LibraryService : ILibraryService
{
    private readonly List<Loan> _loans = new();
    private readonly List<Book> _books = new();
    private readonly List<Member> _members = new();

    public void BorrowBook(Book book, Member member)
    {
        if (book is null) throw new ArgumentNullException(nameof(book));
        if (member is null) throw new ArgumentNullException(nameof(member));

        var alreadyBorrowed = _loans.Any( l =>
            l.Book == book && l.Member == member && !l.IsReturned
        );
        
        if(alreadyBorrowed)
            throw new InvalidOperationException($"{member.FirstName} already borrowed this book");

        book.BorrowCopy(); //proverava da li ima kopija
        var loan = new Loan(book,member);
        _loans.Add(loan);
       
    }

    public void ReturnBook(Book book, Member member)
    {
        var loan = _loans.FirstOrDefault(l => l.Book == book && l.Member == member && !l.IsReturned) ?? throw new InvalidOperationException("No active loan found for this book.");

        loan.ReturnBook();
        book.ReturnCopy() ;
    }
    public  Book AddBook(string title, string author, int copies)
    {
        var book = new Book(title,author,copies);
        _books.Add(book);
        return book;

    }
    public Member RegisterMember(string firstName, string lastName)
    {
        var member = new Member(firstName, lastName);
        _members.Add(member);
        return member;
    }
    public IReadOnlyList<Book> GetAllBooks()
    {
        return _books.AsReadOnly();
    }
    public IReadOnlyList<Member> GetAllMembers()
    {
        return _members.AsReadOnly();
    }
    public IReadOnlyList<Book> GetAvaivableBooks()
    {
        return _books
                    .Where(b => b.AvaivableCopies > 0)
                    .ToList()
                    .AsReadOnly();
    }
    public IReadOnlyList<Loan> GetActiveLoansForMember(Member member)
    {
        return _loans
                    .Where(l => l.Member == member && !l.IsReturned)
                    .ToList()
                    .AsReadOnly();
    }

}