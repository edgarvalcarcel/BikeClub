using BikeClub.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeClub.Domain.Clubs
{
    public class Club : IEntity
    {
        public int Id { get; set; }
        public string GovermentBusinessId { get; set; }
       public string Name { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string PBX { get; set; }
        public string MobilePhoneMain { get; set; }
        public string MobilePhoneAlt{ get; set; }
        public string Website { get; set; }
        public string Email { get; set; }
        public string Logo { get; set; }
    }
}
