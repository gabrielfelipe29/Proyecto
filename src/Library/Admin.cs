namespace Library;


public class Admin : IPerson
{

    public string Name { get; }

    public string UserName { get; }

    public string Email { get; }

    private string Password;

    public Admin(string name, string username, string email, string Password)
    {
        this.Name = name;
        this.UserName = username;
        this.Email = email;
        this.Password = Password;

    }
    public void Register()
    {


    }

    public void Login()
    {


    }


    void CreateCategory()
    {


    }

    private Service GetService()
    {

        return new Service();

    }
}