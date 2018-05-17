using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAEMS.Data
{
    public interface IEventDataSource
    {
        IQueryable<Event> Events { get; set; }
    }
}
