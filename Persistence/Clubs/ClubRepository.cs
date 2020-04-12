using BikeClub.Application.Interfaces.Persistence;
using BikeClub.Domain.Clubs;
using BikeClub.Persistence.Shared;

namespace BikeClub.Persistence.Clubs
{
    public class ClubRepository
        : Repository<Club>, IClubRepository
    {
        public ClubRepository(IDatabaseContext database)
            : base(database) { }
    }
}