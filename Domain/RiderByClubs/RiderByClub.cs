using BikeClub.Domain.Clubs;
using BikeClub.Domain.Common;
using BikeClub.Domain.Riders;
using BikeClub.Domain.Categories;
using System;
using System.Collections.Generic;

namespace BikeClub.Domain.RiderByClubs
{
    public class RiderByClub: IEntity
    {
        public int Id { get; set; }
        public int ClubId { get; set; }
        public Club Club { get; set; }
        public int RiderId { get; set; }
        public Rider Rider { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string QRCode { get; set; }
        public string JerseyNumber { get; set; }
    }
}
