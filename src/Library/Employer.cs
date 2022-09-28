using System;
using System.Collections.Generic;
namespace Library;
public class Employer : IPerson
{
    public string Name { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public int PhoneNumber { get; set; }
    public Location Location { get; set; }
    public List<Request> RequestList { get; set; }

    public Employer(string name,string Username, string Email, string Password, int PhoneNumber, Location Location )
    { 
        this.Name= name;
        this.UserName=Username;
        this.Email=Email;
        this.Password= Password;
        this.PhoneNumber=PhoneNumber;
        this.Location=Location; 
    }

    public void Register()
    {

    }
    public void Login()
    {

    }
    public Service GetService()
    {
        return new Service("", new Employee("", "", ",", "", 0, new Location("", 0, 0, 0)), 0.0, true);
    }
    public double GetRatingAverage()
    {
        return 0.0;
    }

    public void AddRequest()
    {


    }

}