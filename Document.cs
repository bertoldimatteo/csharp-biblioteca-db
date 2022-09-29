public class Document
{
    public int code { get; set; }
    public string title { get; set; }
    public int year { get; set; }
    public string typo { get; set; }
    public bool status { get; set; }
    public string position { get; set; }
    public string author { get; set; }

    public Document(int code, string title)
    {
        this.code = code;
        this.title = title; 
    }
}
