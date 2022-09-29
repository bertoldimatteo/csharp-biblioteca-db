// See https://aka.ms/new-console-template for more information

using System.Data.SqlClient;

string stringaDiConnessione = "Data Source=localhost;Initial Catalog=biblioteca-db;Integrated Security=True";

Library library = new Library();

User userRegistered = new User("Mario", "Rossi", "mail@mail.com", "lamiapassword123", 123456789);
User userAnonimous = new User("null", "null", "null", "null", 123456789);

library.newUser(userRegistered);

SqlConnection connessioneSql = new SqlConnection(stringaDiConnessione);

try
{
    connessioneSql.Open();

    string queryBook = "INSERT INTO Libro (ISBN, titolo, autore, pagine) VALUES ()";

    SqlCommand cmd = new SqlCommand(queryBook, connessioneSql);
    cmd.Parameters.Add(new SqlParameter("@ISBN", "5555555"));
    cmd.Parameters.Add(new SqlParameter("@titolo", "Star Wars"));
    cmd.Parameters.Add(new SqlParameter("@autore", "George Lucas"));
    cmd.Parameters.Add(new SqlParameter("@pagine", "500"));

}   
catch (Exception ex)
    {
        Console.WriteLine(ex.ToString());
    }
    finally
    {
        connessioneSql.Close();
    }

//using System.Runtime.InteropServices;



//List<Document> risultati = library.searchElements("guerra");
//Console.WriteLine(risultati[0].title);