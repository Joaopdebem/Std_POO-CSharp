using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Balta.ContentContext;
using Balta.ContentContext.Enums;

namespace Balta;

public class Program
{
    static void Main(string[] args)
    {
        //Console.Clear();
        var articles = new List<Article>();
        articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
        articles.Add(new Article("Artigo sobre C#", "csharp"));
        articles.Add(new Article("Artigo sobre .NET", "dotnet"));

        /*foreach (var article in articles)
        {
            Console.WriteLine($"Artigo: {article.Title} - Id: {article.Id} - Url: /{article.Url}");
        }*/

        Console.WriteLine();
        var courses = new List<Course>();
        var courseOOP = new Course("Fundamentos OOP", "fundamentos-oop", EContentLevel.Fundamental);
        var courseCSharp = new Course("Fundamentos C#", "fundamentos-csharp", EContentLevel.Beginner);
        var courseAspnet = new Course("Fundamentos ASP.NET", "fundamentos-aspnet", EContentLevel.Intermediary);

        courses.Add(courseOOP);
        courses.Add(courseCSharp);
        courses.Add(courseAspnet);

        /*foreach (var course in courses)
        {
            Console.WriteLine($"Curso: {course.Title} - Id: {course.Id} - Url: /{course.Url}");
        }*/

        Console.WriteLine();
        var careers = new List<Career>();
        var careerDotnet = new Career("Especialista .NET", "especialista-dotnet");
        var careerItem2 = new CareerItem(2, "Aprenda OOP", "", courseOOP);
        var careerItem = new CareerItem(1, "Comece por arqui", "", courseCSharp);
        var careerItem3 = new CareerItem(3, "Aprenda .NET", "", courseAspnet);

        careerDotnet.Items.Add(careerItem2);
        careerDotnet.Items.Add(careerItem);
        careerDotnet.Items.Add(careerItem3);

        careers.Add(careerDotnet);

        foreach (var career in careers)
        {
            Console.WriteLine($"Carreira: {career.Title}");
            foreach (var item in career.Items.OrderBy(x => x.Order))
            {
                Console.WriteLine($"{item.Order} - {item.Title}");
                Console.WriteLine($"Curso: {item.Course?.Title} - Level: {item.Course?.Level.ToString()}");
            }
        }

    }
}