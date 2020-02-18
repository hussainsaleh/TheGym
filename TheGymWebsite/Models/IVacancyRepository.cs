using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheGymWebsite.Models
{
    public interface IVacancyRepository
    {
        Vacancy GetVacancy(int id);
        IEnumerable<Vacancy> GetAllVacancies();
        void Add(Vacancy vacancy);
        void Update(Vacancy changedVacancy);
        void Delete(int id);
    }
}
