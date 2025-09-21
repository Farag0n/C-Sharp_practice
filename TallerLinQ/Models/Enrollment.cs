namespace TallerLinQ.Models;

public class Enrollment
{
    public int id { get; set; }
    public int StudentId { get; set; }
    public int CourseId { get; set; }
    public double grade { get; set; }
};
