using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capstone.Domain.Abstract;

namespace Capstone.Domain.Concrete
{
    public class PartnershipNightRepository : PartnershipNightInterface
    {

        public bool AddPartnershipNight(Entities.PartnershipNight pn)
        {
            throw new NotImplementedException();
        }

        public Entities.PartnershipNight GetPartnershipNightById(string eventId)
        {
            throw new NotImplementedException();
        }

        public Entities.PartnershipNight GetPartnershipNightByDate(DateTime date, Entities.BvLocation loc)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Entities.PartnershipNight> GetPartnershipNightsByMonth(DateTime extractMonthAndYear)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Entities.PartnershipNight> GetPartnershipNightsByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Entities.PartnershipNight> GetPartnershipNightsByLoc(Entities.BvLocation loc)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Entities.PartnershipNight> GetPartnershipNightsByDateRange(DateTime firstDate, DateTime lastDate, Entities.BvLocation loc)
        {
            throw new NotImplementedException();
        }

        public Entities.PartnershipNight UpdatePartnershipNight(Entities.PartnershipNight pn)
        {
            throw new NotImplementedException();
        }

        public bool DeletePartnershipNight(Entities.PartnershipNight pn)
        {
            throw new NotImplementedException();
        }
    }
}
