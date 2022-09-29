public class Movie : Document
{
    public Movie(int code, string title) : base(code, title)
    {
        this.code = code;
        this.title = title;
    }
    public int minute { get; set; }
}
