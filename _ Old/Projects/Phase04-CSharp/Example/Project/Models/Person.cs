namespace Project.Models {
    public class Person {
        public Person () {

        }

        public Person (string firstName, string lastName) {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}