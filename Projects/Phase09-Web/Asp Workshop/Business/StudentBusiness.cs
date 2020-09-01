using Asp_Workshop.Abstarction;
using Asp_Workshop.Models;

namespace Asp_Workshop.Business {
    public class StudentBusiness : IPersonBusiness {
        private readonly IScoreBusiness scoreBusiness;

        public StudentBusiness (IScoreBusiness scoreBusiness) {
            this.scoreBusiness = scoreBusiness;
        }

        public Person Get (int id) {
            return new Student () {
                Id = id,
                    FirstName = "محمد حسین",
                    LastName = "مستمند",
                    Scores = scoreBusiness.GetScoreByStudentId (id)
            };
        }
    }
}