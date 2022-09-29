// See https://aka.ms/new-console-template for more information

using System.Runtime.InteropServices;

Library library = new Library();

Book firstBook = new Book(123456789, "L'arte della guerra");
firstBook.pages = 200;

Movie firstMovie = new Movie(123456789, "Star Wars L'impero colpisce ancora");
firstMovie.minute = 150;

Console.WriteLine(firstBook.title);
Console.WriteLine(firstMovie.title);

User userRegistered = new User("Mario", "Rossi", "mail@mail.com", "lamiapassword123", 123456789);
User userAnonimous = new User("null", "null", "null", "null", 123456789);

library.newUser(userRegistered);

List<Document> risultati = library.searchElements("guerra");
Console.WriteLine(risultati[0].title);