using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Project.Models;

namespace Project {
    class Program {
        private const string Path = "person.json";

        static void Main (string[] args) {
            // var array = new int[] { 1, 11, 3, 0, 15, 5, 2, 4, 10, 7, 12, 6 };

            // ProblemSovler sovler = new ProblemSovler (array);

            // var result = sovler.Solve ();

            // Console.WriteLine (result);

            var json = File.ReadAllText(Path);

            var persons = JsonSerializer.Deserialize<List<Person>>(json);

            Console.WriteLine(persons.First().FirstName);
        }
    }
}