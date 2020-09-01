using System.Collections.Generic;
using Asp_Workshop.Abstarction;
using Asp_Workshop.Models;

namespace Asp_Workshop.Business {
    public class ScoreBusiness : IScoreBusiness {
        public List<Score> GetScoreByStudentId (int id) {
            return new List<Score> () {
                new Score {
                    Course = "DB",
                        Point = 20
                },
                new Score {
                    Course = "OS",
                        Point = 19.8
                }
            };
        }
    }
}