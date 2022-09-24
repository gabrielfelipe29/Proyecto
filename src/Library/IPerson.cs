namespace Library;

public interface IPerson
{
    public string Name { get; }
    public string UserName { get; }

    public string Email { get; }
    public string Password { get; }


    public void Register();
    public void Login();

}