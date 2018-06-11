using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAEMS.Data
{
    public class Event
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Date { get; set; }
        public virtual decimal Registration { get; set; }
        public virtual string Location { get; set; }
        public virtual string Street { get; set; }
        public virtual string City { get; set; }
        public virtual string Counrty { get; set; }
    }
}
