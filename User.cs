public class User {
    public string name { get; set; }
    public string surname { get; set; }
    public string email { get; set; }
    public string password { get; set; }
    public int mobilePhone { get; set; }
    public bool registered { get; set; }

    public User(string name, string surname, string email, string password, int mobilePhone)
    {
        this.name = name;
        this.surname = surname;
        this.email = email;
        this.password = password;
        this.mobilePhone = mobilePhone;
    }
}
