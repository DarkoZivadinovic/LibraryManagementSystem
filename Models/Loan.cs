public class Loan
{
    public int Id { get; private set; }
    public DateTime LoanDate { get; private set; }
    public DateTime? ReturnDate { get; private set; }

    public bool IsReturned { get { return ReturnDate.HasValue; }}

    public Book Book  { get; private set; }
    public Member Member{ get; private set; }

    public Loan (Book book , Member member)
    {
        if(book == null)
            throw new ArgumentNullException(nameof(book));
        if(member == null)
            throw new ArgumentNullException(nameof(member));
        
        Book = book;
        Member = member;
        LoanDate = DateTime.Now;
    }

    public void ReturnBook()
    {
        if(IsReturned)
            throw new InvalidOperationException("Book already returned.");
        
        ReturnDate = DateTime.Now;
    }


}