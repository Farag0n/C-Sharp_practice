using System;
namespace DefaultNamespace;

public abstract class LibraryMaterials
{
    protected string Title;
    protected string Author;
    protected string Language;
    protected int Year;
    protected int Copies;
    
    protected string Content

    public LibraryMarial(string title, string author, string language, int year, int copies, string content)
    {
        Title = title;
        Author = author;
        Language = language;
        Year = year;
        Copies = copies;
        Content = content;
    }
    
    public abstract void ShowInfo()
    {
   
    }

    public void Read()
    {
        Console.WriteLine("Estas leyendo")
    }
}