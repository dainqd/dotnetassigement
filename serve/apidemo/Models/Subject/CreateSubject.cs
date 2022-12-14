using apidemo.Entities;

namespace apidemo.Models.Subject;

public class CreateSubject
{
    public string Name { get; set; } = "";
    public DateTime StartTime { get; set; } = DateTime.Now;
    public DateTime Date { get; set; } = DateTime.Today;
    public int Duration { get; set; }  = 60;
    public string ClassRoom { get; set; } = "";
    public string Faculty { get; set; } = "";
    
    public string Status { get; set; } = "PREACTIVE";
}