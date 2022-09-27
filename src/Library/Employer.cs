using System;
<<<<<<< HEAD
namespace Library;
public class Employer: IPerson
=======
using System.Collections.Generic;
namespace Library;
public class Employer : IPerson
>>>>>>> d223b0dc22e5f814ea85be100c1b58a45a4250af
{
    public string Name { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public int PhoneNumber { get; set; }
    public Location Location { get; set; }
    public List<Request> RequestList { get; set; }

    public void Register()
    {

    }
    public void Login()
    {

    }
    public Service GetService()
    {
        return new Service("", new Employee(), 0.0, true);
    }
    public double GetRatingAverage()
    {
        return 0.0;
    }

    public void AddRequest()
    {


    }

}