using BikeClub.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeClub.Domain.Riders
{
    public class Rider : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string GovermentId { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string PBX { get; set; }
        public string MobilePhoneMain { get; set; }
        public string MobilePhoneAlt { get; set; }
        public string JerseyNumber { get; set; }
        public string BlogWeb { get; set; }
        public string Photo { get; set; }
        public string Email { get; set; }
    }
}


