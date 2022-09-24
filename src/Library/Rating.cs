using System; 
namespace Library;

public class Rating
{
    public Rating (string comment, DateTime date, int rate)
    {
        this.Comment = comment;
        this.Date = date;
        this.Rate = rate;
    }

    public string Comment { get; set; }
    public DateTime Date { get; set; }
    public int Rate { get; set; }
    
}