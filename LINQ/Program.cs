using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>
            {
                new Person { Name = "Alice", Age = 30 },
                new Person { Name = "Bob", Age = 25 },
                new Person { Name = "Charlie", Age = 35 },
                new Person { Name = "David", Age = 28 },
                new Person { Name = "Eve", Age = 40 }
            };

            // Use LINQ to query the data
            var adults = people.Where(p => p.Age >= 30); // Filter people aged 30 or older
            var namesStartWithA = people.Where(p => p.Name.StartsWith("A")); // Filter people with names starting with 'A'
            var nameList = people.Select(p => p.Name); // Extract names as a list
            var averageAge = people.Average(p => p.Age); // Calculate the average age

            // Print the results
            Console.WriteLine("Adults (30 or older):");
            foreach (var adult in adults)
            {
                Console.WriteLine($"Name: {adult.Name}, Age: {adult.Age}");
            }

            Console.WriteLine("\nNames starting with 'A':");
            foreach (var person in namesStartWithA)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            }

            Console.WriteLine("\nList of Names:");
            foreach (var name in nameList)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine($"\nAverage Age: {averageAge}");

            Console.ReadLine();
        }
    }
}
