using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAEMS.Data;

namespace MAEMS.Services
{
    public class EventsService
    {
        public IQueryable<Event> GetEventLists()
        {
            var eventNameList = new IEventDataSource.Events;

            return eventNameList;
        }
    }
}
