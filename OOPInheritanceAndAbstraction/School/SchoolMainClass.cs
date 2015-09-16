using System;
using System.Collections.Generic;

class SchoolMainClass
{
    static void Main()
    {
        IList<Student> students = new List<Student>
        {
            new Student("Lubomir Antonov", 4),
            new Student("Angel Vladev", 1),
            new Student("Zvetan Popov", 5),
            new Student("Gergana Ilova", 2),
            new Student("Hristo Kolev", 3)
        };

        var html = new Discipline("HTML", 6);
        html.AddStudent(students[0]);
        html.AddStudent(students[2]);
        html.AddStudent(students[4]);
        html.Details = "Online";

        var css = new Discipline("CSS", 5);
        css.AddStudent(students[0]);
        css.AddStudent(students[1]);
        css.AddStudent(students[2]);

        var java = new Discipline("Java", 4);
        java.AddStudent(students[1]);
        java.AddStudent(students[3]);
        java.AddStudent(students[4]);

        var javaScript = new Discipline("JavaScript", 5, students);

        var webDevelopmentTeacher = new Teacher("Vasil Cekov");
        webDevelopmentTeacher.AddDiscipline(html);
        webDevelopmentTeacher.AddDiscipline(css);
        webDevelopmentTeacher.AddDiscipline(javaScript);

        var javaDevelopmentTeacher = new Teacher("Branimir Vutov");
        javaDevelopmentTeacher.AddDiscipline(java);

        var classA = new Class("A", new List<Teacher> { webDevelopmentTeacher, javaDevelopmentTeacher });

        string str = classA.ToString();
        Console.WriteLine(classA);

    }
}