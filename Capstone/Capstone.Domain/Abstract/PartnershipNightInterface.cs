﻿using Capstone.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Domain.Abstract
{
    public interface PartnershipNightInterface
    {
        void AddPartnershipNight(PartnershipNight pn);
        PartnershipNight GetPartnershipNightById(string eventId);
        PartnershipNight GetPartnershipNightByDate(DateTime date, BvLocation loc); // returns a particular partnership night, given the bv locaion and date
        IQueryable<PartnershipNight> GetPartnershipNightsByMonth(DateTime extractMonthAndYear); // For calendar:  gets all partnership nights scheduled for a given month.  Might not be necessary - just sticking it in for now.
        IQueryable<PartnershipNight> GetPartnershipNightsByDate(DateTime date); //returns all partnership events on a given date - spanning all locations
        IQueryable<PartnershipNight> GetPartnershipNightsByLoc(BvLocation loc); // returns all partnership nights for a given location
        IQueryable<PartnershipNight> GetPartnershipNightsByDateRange(DateTime firstDate, DateTime lastDate, BvLocation loc); // returns all partnership nights for a given location, within the specified date range
        PartnershipNight UpdatePartnershipNight(PartnershipNight pn);
        void DeletePartnershipNight(PartnershipNight pn);
        //TODO: do we want to be able to get all upcoming (not past) events too? or all upcoming for one location? 
    }
}
