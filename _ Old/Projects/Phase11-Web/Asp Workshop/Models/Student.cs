using System.Collections.Generic;

namespace Asp_Workshop.Models {
    public class Student : Person {
        public List<Score> Scores { get; set; }
    }
}