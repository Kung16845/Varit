public class Email
{
    private string email;
    private string password;

    public Email(string Email,string password)
    {
        this.email = Email;
        this.password = password;
    }
    public string GetEmail()
    {
        return this.email;
    }
    public string GetPassword()
    {
        return this.password;
    }
}
