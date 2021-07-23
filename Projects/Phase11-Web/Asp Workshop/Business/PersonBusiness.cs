using Asp_Workshop.Abstarction;
using Asp_Workshop.Models;

namespace Asp_Workshop.Business {
    public class PersonBusiness : IPersonBusiness {
        public Person Get (int id) {
            return new Person () {
                FirstName = "Mahdi",
                    LastName = "Malverdi"
            };
        }
    }
}