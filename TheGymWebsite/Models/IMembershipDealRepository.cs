using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheGymWebsite.Models
{
    public interface IMembershipDealRepository
    {
        MembershipDeal GetMembershipDeal(int id);
        bool IsDurationOffered(Enums.MembershipDuration duration);
        IEnumerable<MembershipDeal> GetAllMembershipDeals();
        void Add(MembershipDeal membershipDeal);
        void Update(MembershipDeal changedMembershipDeal);
        void Delete(int id);
    }
}
