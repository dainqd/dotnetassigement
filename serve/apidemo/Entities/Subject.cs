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
    public string StartTime { get; set; } = "";
    public string Date { get; set; } = "";
    public int Duration { get; set; }  = 60;
    public string ClassRoom { get; set; } = "";
    public string Faculty { get; set; } = "";
    
    public SubjectStatus Status { get; set; } = SubjectStatus.PREACTIVE;
}