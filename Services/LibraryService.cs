public class LibraryService : ILibraryService
{
    private readonly List<Loan> _loans = new();

    public void BorrowBook(Book book, Member member)
    {
        
        book.BorrowCopy(); //proverava da li ima kopija
        var loan = new Loan(book,member);
        _loans.Add(loan);
       
    }

    public void ReturnBook(Book book,Member member)
    {
        var loan = _loans.FirstOrDefault(l => l.Book == book && l.Member == member && !l.IsReturned) ?? throw new InvalidOperationException("No active loan found for this book.");

        loan.ReturnBook();
        book.ReturnCopy() ;
    }
}