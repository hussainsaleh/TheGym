using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheGymWebsite.Models
{
    public interface IOpenHoursRepository
    {
        OpenHours GetOpenHours(int id);
        IEnumerable<OpenHours> GetAllOpenHours();
        void Add(OpenHours openHours);
        void Update(OpenHours changedOpenHours);
        void Delete(int id);
    }
}
