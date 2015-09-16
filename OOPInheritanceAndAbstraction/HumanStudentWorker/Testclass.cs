using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanStudentWorker
{
    public class PlayWithHumans
    {
        static void Main()
        {
            Worker lubomir = new Worker("Lubomir", "Antonov", 400, 8);
            Student student = new Student("Mihaela", "Antonova", "53829920");

            Console.WriteLine(lubomir);
            Console.WriteLine("Money per hour: " + lubomir.MoneyPerHour());
            Console.WriteLine(student);
            Console.WriteLine();
            Console.WriteLine();

            List<Student> students = new List<Student>()
            {
                new Student("Lubomir", "Antonov", "62784939"),
                new Student("Sladunka", "Savova", "28382399"),
                new Student("Hristo", "Panajotov", "78283494"),
                new Student("Temelko", "Tomov", "8839499499"),
                new Student("Roza", "Gerova", "3788484949"),
                new Student("Toma", "Deskov", "6288949940"),
                new Student("Hristo", "Vutov", "8283494"),
                new Student("Kostao", "Tomov", "9839499499"),
                new Student("Zara", "Gerova", "2388484949"),
                new Student("Ognian", "Delkov", "8288949940"),
            };

            Console.WriteLine("Students orderby factualy number in ascending order: \n");
            students.OrderBy(s => s.FacultyNumber)
                .ToList().ForEach(s => Console.WriteLine(s.ToString()));

            List<Worker> workers = new List<Worker>()
            {
                new Worker("Gergana", "Bojilova", 400, 4),
                new Worker("Georgi", "Lilov", 500, 6),
                new Worker("Angel", "Olegov", 800, 8),
                new Worker("Reni", "Bokova", 900, 8),
                new Worker("Naiden", "Velev", 400, 3),
                new Worker("Galabin", "Bojilov", 1000, 4),
                new Worker("Ana", "Veleva", 1000, 4),
                new Worker("Gergana", "Traikova", 700, 5),
                new Worker("Jivko", "Tomov", 1400, 8),
                new Worker("Nadia", "Ognianova", 2000, 4),
            };

            Console.WriteLine();
            Console.WriteLine("Workers ordered by payment per hour in descending order: \n");
            workers.OrderByDescending(w => w.MoneyPerHour())
                .ToList().ForEach(w => Console.WriteLine(w.ToString()));

            List<Human> mergedList = new List<Human>();
            mergedList.AddRange(students);
            mergedList.AddRange(workers);
            Console.WriteLine();
            Console.WriteLine("Merged list of students and workers order by first name:s \n");
            mergedList.OrderBy(h => h.FirstName).ThenBy(h => h.LastName).ToList()
                .ForEach(h => Console.WriteLine(h.ToString()));

        }
    }
}