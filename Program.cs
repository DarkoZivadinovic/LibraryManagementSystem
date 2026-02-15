// See https://aka.ms/new-console-template for more information
var library = new LibraryService();

Console.WriteLine("=== MINI TEST START ===");


var book1 = library.AddBook("Clean Code", "Robert C. Martin", 3);
var book2 = library.AddBook("The Pragmatic Programmer", "Andrew Hunt", 2);

Console.WriteLine($"Book1 copies: {book1.AvailableCopies}");
Console.WriteLine($"Book2 copies: {book2.AvailableCopies}");


var member = library.RegisterMember("Pera", "Peric");

Console.WriteLine($"Member registered: {member.FullName}");


library.BorrowBook(book1, member);
Console.WriteLine($"After borrow - Book1 copies: {book1.AvailableCopies}");


library.ReturnBook(book1, member);
Console.WriteLine($"After return - Book1 copies: {book1.AvailableCopies}");

Console.WriteLine("=== MINI TEST END ===");

