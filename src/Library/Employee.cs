using System;
namespace Library;
public class Employee: IPerson
{
    public string Name { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    private string Passaword { get; set; }
    private int PhoneNumber {get; set; }
    private Location Location {get; set; }
    private List<Request> RequestList {get; set; }
    public void Register()
    {
        
    }
    public void Login()
    {
        
    }
    public Service CreateService()
    {
        //sale error porque falta el valor a retornar (de tipo Service)
    }
    public double GetRatingAverage()
    {
          //sale error porque falta el valor a retornar (un double)
    }
    public void AddRequest()
    {

    }

}