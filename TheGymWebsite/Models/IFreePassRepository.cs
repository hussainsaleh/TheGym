using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheGymWebsite.Models
{
    public interface IFreePassRepository
    {
        FreePass GetFreePass(int id);
        public int GetFreePassId(string email);
        IEnumerable<FreePass> GetAllFreePasses();
        void Add(FreePass freePass);
        void Update(FreePass changedFreePass);
        void Delete(int id);
    }
}
