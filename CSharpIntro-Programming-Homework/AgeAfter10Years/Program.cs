using System;

class AgeAfter10Years
{
    private static void Main(string[] args)
    {
        DateTime birthDay; // Declaring variable 'birthDay' of type 'DateTime'

        Console.WriteLine("Please enter the birthday in proper format (e.g. dd.mm.yyyy)");

        if (DateTime.TryParse(Console.ReadLine(), out birthDay)) // Getting birthdate and initializing it to 'birthDay'
        {
            DateTime today = DateTime.Today; // Getting the current date

            int age = today.Year - birthDay.Year; //Getting the age

            if (birthDay > today.AddYears(-age)) age--; // Checking for accuracy of the age

            Console.WriteLine("After 10 years you will be:" + (age + 10)); // Displaying the age after 10 years
        }
        else
        {
            Console.WriteLine("Please enter the birthday in proper format (e.g. dd.mm.yyyy)");
        }
    }
}