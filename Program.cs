// See https://aka.ms/new-console-template for more information
var library = new LibraryService();

Console.WriteLine("=== MINI TEST START ===");


var book1 = library.AddBook("Clean Code", "Robert C. Martin", 3);
var book2 = library.AddBook("The Pragmatic Programmer", "Andrew Hunt", 2);

Console.WriteLine($"Book1 copies: {book1.AvaivableCopies}");
Console.WriteLine($"Book2 copies: {book2.AvaivableCopies}");


var member = library.RegisterMember("Pera", "Peric");

Console.WriteLine($"Member registered: {member.FullName}");


library.BorrowBook(book1, member);
Console.WriteLine($"After borrow - Book1 copies: {book1.AvaivableCopies}");

library.ReturnBook(book1, member);
Console.WriteLine($"After return - Book1 copies: {book1.AvaivableCopies}");

Console.WriteLine("\nAvailable books:");

var availableBooks = library.GetAvaivableBooks();

foreach (var b in availableBooks)
{
    Console.WriteLine($"{b.Title} - copies: {b.AvaivableCopies}");
}

Console.WriteLine("\nActive loans for member:");

var activeLoans = library.GetActiveLoansForMember(member);

foreach (var loan in activeLoans)
{
    Console.WriteLine(loan.Book.Title);
}



Console.WriteLine("=== MINI TEST END ===");

