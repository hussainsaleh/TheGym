using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheGymWebsite.Models
{
    public interface IGymRepository
    {
        Gym GetGym(int id);
        IEnumerable<Gym> GetAllGyms();
        void Add(Gym gym);
        void Update(Gym changedGym);
        void Delete(int id);
    }
}
