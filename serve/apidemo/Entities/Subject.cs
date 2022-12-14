using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace apidemo.Entities;

public class Subject
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public string Name { get; set; } = "";
    public DateTime StartTime { get; set; } = DateTime.Now;
    public DateTime Date { get; set; } = DateTime.Today;
    public int Duration { get; set; }  = 60;
    public string ClassRoom { get; set; } = "";
    public string Faculty { get; set; } = "";
    
    public SubjectStatus Status { get; set; } = SubjectStatus.PREACTIVE;
}