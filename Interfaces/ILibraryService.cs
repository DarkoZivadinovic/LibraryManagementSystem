public interface ILibraryService
{
    void BorrowBook(Book book, Member member);
    void ReturnBook(Book book, Member member);
    Book AddBook(string title, string author, int copies);
    Member RegisterMember(string firstName, string lastName);

    IReadOnlyList<Book> GetAllBooks();
    IReadOnlyList<Member> GetAllMembers();
    IReadOnlyList<Book> GetAvaivableBooks();
    IReadOnlyList<Loan> GetActiveLoansForMember(Member member);

}