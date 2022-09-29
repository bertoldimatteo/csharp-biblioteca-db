using static System.Reflection.Metadata.BlobBuilder;

public class Library
{
    protected List<User> userRegistered = new List<User>();

    protected List<Movie> Movie = new List<Movie>();

    protected List<Book> Book = new List<Book>();

    public void newUser(User user)
    {
        user.registered = true;
        userRegistered.Add(user);   
    }

    public List<Document> searchElements(string title)
    {
        List<Document> results = new List<Document>();

        foreach (Book book in Book)
        {
            if (book.title.Contains(title))
            {
                results.Add(book);
            }
        }

        foreach (Movie movie in Movie)
        {
            if (movie.title.Contains(title))
            {
                results.Add(movie);
            }
        }
        return results;
    }
}