using System.Collections.Generic;
namespace Library;

public class Employee : IPerson
{
    public string Name { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public int PhoneNumber { get; set; }
    public Location Location { get; set; }
    public List<Request> RequestList { get; set; }

    public Employee(string name, string Username, string Email, string Password, int PhoneNumber, Location Location)
    {
        this.Name = name;
        this.UserName = Username;
        this.Email = Email;
        this.Password = Password;
        this.PhoneNumber = PhoneNumber;
        this.Location = Location;
    }

    //Método para Registrarse
    public void Register()
    {

    }

    //Método para iniciar sesión
    public void Login()
    {

    }
    //Método para crear un servicio del trabajador
    public Service CreateService()
    {
        //sale error porque falta el valor a retornar (de tipo Service)
        return new Service("", new Employee("", "", ",", "", 0, new Location("", 0, 0, 0)), 0.0, true);
    }

    //Método para obtener la calificación
    public double GetRatingAverage()
    {
        //sale error porque falta el valor a retornar (un double)
        return 0.0;
    }

    //Método empleado para las solicitudes de Trabajo
    public void AddRequest()
    {

    }

}