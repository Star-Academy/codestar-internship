using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Nest;
using NestSampleCode.Models;

namespace NestSampleCode 
{
    class Program 
    {
        private const string Path = "people.json";
        private const string IndexName = "my-s";

        static void Main (string[] args)
        {
            var indexDefiner = new IndexDefiner();
            indexDefiner.CreateIndex(IndexName);
            // var people = ReadPeople();
            // IndexPeople(people);
        }

        private static void IndexPeople(List<Person> people)
        {
            var importer = new Importer<Person>();
            importer.Import(people, IndexName);
        }

        private static List<Person> ReadPeople()
        {
            var json = File.ReadAllText(Path);
            var people = JsonSerializer.Deserialize<List<Person>>(json);
            return people;
        }
    }
}