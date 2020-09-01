using Asp_Workshop.Models;

namespace Asp_Workshop.Abstarction
{
    public interface IPersonBusiness
    {
        Person Get(int id);
    }
}