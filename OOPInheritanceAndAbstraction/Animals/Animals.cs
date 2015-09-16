using System;
using System.Collections.Generic;
using System.Linq;

namespace Animals
{
    class Animals
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>()
            {
                new Dog("Misho", 5, Gender.Male),
                new Dog("Argo", 1, Gender.Male),
                new Dog("Larisa", 4, Gender.Female),
                new Frog("Buba", 3, Gender.Female),
                new Frog("Sani", 1, Gender.Male),
                new Kitten("Kitti", 3),
                new Tomcat("Neon", 6),
                new Cat("Suzi", 7, Gender.Female)
            };

                var averageAge =
                from animal in animals
                group animal by animal.GetType() into g
                select new { GroupName = g.Key.Name, 
                    AverageAge = g.Average(a => a.Age) };

            averageAge.ToList().ForEach
            (a => Console.WriteLine(a.GroupName + "--->" + a.AverageAge)); 
        }
    }
}
