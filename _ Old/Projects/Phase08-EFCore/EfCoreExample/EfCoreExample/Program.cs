using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EfCoreExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new ExampleContext();

            context.Database.EnsureCreated();

            context.Students.Add(new Student() { LastName = "مالوردی", Name = "مهدی" });
            context.Students.Add(new Student() { LastName = "عرب زاده", Name = "امیرحسین" });
            context.Students.Add(new Student() { LastName = "کوششی", Name = "امیر مهدی" });
            context.Students.Add(new Student() { LastName = "آقایی", Name = "حسین" });
            context.Students.Add(new Student() { LastName = "آقایی", Name = "حسین" });

            context.SaveChanges();

            context.Grades.Add(new Grade() { Score = 20, StudentId = 1 });
            context.Grades.Add(new Grade() { Score = 10, StudentId = 4 });
            context.Grades.Add(new Grade() { Score = 19, StudentId = 3 });
            context.Grades.Add(new Grade() { Score = -5, StudentId = 2 });

            context.SaveChanges();

            var student1 = context.Students.ToList();
            var student2 = context.Students
                .Join(context.Grades, s => s.Id, g => g.StudentId , (s,g) => g.Score)
                .DefaultIfEmpty()
                .ToList();
        }
    }
}
