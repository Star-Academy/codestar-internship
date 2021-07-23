using Education.Models;

namespace Education.Test
{
    public class StudentScoreRepositoryTests : RepositoryTests<StudentScore>
    {
        protected override StudentScore CreateEntity()
        {
            return new StudentScore
            {
                StudentId = 1,
                Course = "Calculus",
                Score = 14.5
            };
        }
    }
}