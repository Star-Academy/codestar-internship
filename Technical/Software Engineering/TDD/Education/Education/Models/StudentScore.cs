namespace Education.Models
{
    public class StudentScore : IModel
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string Course { get; set; }
        public double Score { get; set; }

        public override bool Equals(object obj)
        {
            return obj is StudentScore score &&
                   Id == score.Id &&
                   StudentId == score.StudentId &&
                   Course == score.Course &&
                   Score == score.Score;
        }
    }
}