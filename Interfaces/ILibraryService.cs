public interface ILibraryService
{
    void BorrowBook(Book book, Member member);
    void ReturnBook(Book book);
}