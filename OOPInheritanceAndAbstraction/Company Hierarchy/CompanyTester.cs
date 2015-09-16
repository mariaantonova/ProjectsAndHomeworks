using System;
using System.Collections.Generic;

class CompanyTester
{
    static void Main(string[] args)
    {
        Sale computer = new Sale("Dell", "12-12-2014", 550);
        Sale dvd = new Sale("Philips", "12-12-2014", 400);
        Sale tv = new Sale("LG", "12-12-2014", 600);
        SalesEmployee george = new SalesEmployee(8120402363, "George", "Washington", 1500, Department.Production, dvd);
        SalesEmployee pesho = new SalesEmployee(84254041261, "Peter", "Cetera", 5200, Department.Sales, computer, tv);

        Project web = new Project("haus.bg", "04-04-1982", "some details");
        Project club = new Project("club.bg", "05-05-1945", "some details");
        club.CloseProject();
        Developer lazar = new Developer(84254041261, "Lazar", "Velichkov", 41500, Department.Production, web, club);

        Manager kiro = new Manager(6612129080, "Kiro", "Kirov-Kirist", george, pesho, lazar);

        var listOfPeople = new List<IPerson>();
        listOfPeople.Add(kiro);
        listOfPeople.Add(lazar);
        listOfPeople.Add(pesho);
        listOfPeople.Add(george);

        foreach (var person in listOfPeople)
        {
            Console.WriteLine(person);
            Console.WriteLine("--------------------------------------------------------------------------------");
        }

    }
}