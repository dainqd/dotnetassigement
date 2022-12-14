namespace apidemo.Models.Subject;

public class UpdateSubject
{
    public string Name { get; set; } = "";
    public string StartTime { get; set; } = "";
    public string Date { get; set; } = "";
    public int Duration { get; set; }  = 60;
    public string ClassRoom { get; set; } = "";
    public string Faculty { get; set; } = "";
    
    public string Status { get; set; } = "PREACTIVE";
}