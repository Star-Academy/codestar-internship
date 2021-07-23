using Education.Models;

namespace Education.Test
{
    public class StudentRepositoryTests : RepositoryTests<Student>
    {
        protected override Student CreateEntity()
        {
            return new Student
            {
                FirstName = "Ali",
                LastName = "Alavi"
            };
        }
    }
}