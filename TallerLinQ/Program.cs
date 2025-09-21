using TallerLinQ.Models;

namespace TallerLinQ;

public class Program
{
    static void Main(string[] args)
    {
        //Coleccion de estudiantes
        var students = new List<Student>
        {
            new Student { id = 1, name = "Michael Scot", age = 43 },
            new Student { id = 2, name = "Clark Kent", age = 30 },
            new Student { id = 3, name = "Linus Torvald", age = 55 },
            new Student { id = 4, name = "Robert Oppenheimer", age = 63 },
            new Student { id = 5, name = "Monkey D. Luffy", age = 17 },
            new Student { id = 6, name = "Peter Parker", age = 16 },
            new Student { id = 7, name = "Steve Ditko", age = 97 },
            new Student { id = 8, name = "Water White", age = 20 },
        };
        
        //Coleccion de cursos
        var courses = new List<Course>
        {
            new Course {id = 1, title = "Ventas 1", credits = 9},
            new Course {id = 2, title = "Fisica nuclear", credits = 6},
            new Course {id = 3, title = "Libertad 3", credits = 4},
            new Course {id = 4, title = "Quimica", credits = 5},
            new Course {id = 5, title = "Fotografia", credits = 2},
        };
        
        //Coleccion de Matricula
        var enrrolment = new List<Enrollment>
        {
            new Enrollment {id = 1, StudentId = 1, CourseId = 1},
            new  Enrollment {id = 2, StudentId = 1, CourseId = 1},
            new  Enrollment {id = 3, StudentId = 1, CourseId = 1},
            new  Enrollment {id = 4, StudentId = 1, CourseId = 1},
            new  Enrollment {id = 5, StudentId = 1, CourseId = 1},
            
            
        };
        
        //Consultas
        
}
