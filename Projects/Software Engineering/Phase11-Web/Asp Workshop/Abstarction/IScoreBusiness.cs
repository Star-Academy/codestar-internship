using System.Collections.Generic;
using Asp_Workshop.Models;

namespace Asp_Workshop.Abstarction
{
    public interface IScoreBusiness
    {
        List<Score> GetScoreByStudentId(int id);
    }
}