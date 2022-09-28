namespace Library;


public class Admin : IPerson
{

    public string Name { get; }

    public string UserName { get; }

    public string Email { get; }

    public string Password { get; }

    public Admin(string name, string username, string email, string Password)
    {
        // método constructor del administrador
        this.Name = name;
        this.UserName = username;
        this.Email = email;
        this.Password = Password;

    }
    public void Register()
    {
        // método para que el administrador se registre

    }

    public void Login()
    {
        // método para que el administrador se pueda logear 

    }


    void CreateCategory()
    {
        // método para que el administrador pueda crear una nueva categoria

    }

    private Service GetService()
    {
        // método para que el administrador pueda tener acceso a los servicios
        // se retorna un servicio generico para que no tire un error
        return new Service("", new Employee("", "", ",", "", 0, new Location("", 0, 0, 0)), 0.0, true);
    }
}