namespace Library;

public interface IPerson
{
    public string Name;
    public string UserName;

    public string Email;
    private string Password;


    public void Register();
    public void Login();

}