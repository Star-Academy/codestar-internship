namespace Education.Models
{
    public class Student : IModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Student student &&
                   Id == student.Id &&
                   FirstName == student.FirstName &&
                   LastName == student.LastName;
        }
    }
}