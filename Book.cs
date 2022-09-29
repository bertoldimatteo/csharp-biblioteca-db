public class Book : Document
{
    public Book(int code, string title) : base(code, title)
    {
        this.code = code;
        this.title = title;
    }
    public int pages { get; set; }
}
