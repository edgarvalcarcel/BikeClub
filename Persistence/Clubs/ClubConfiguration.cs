using System.Data.Entity.ModelConfiguration;
using BikeClub.Domain.Clubs;

namespace BikeClub.Persistence.Clubs
{
    public class ClubConfiguration
        : EntityTypeConfiguration<Club>
    {
        public ClubConfiguration()
        {
            HasKey(p => p.Id);

            Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}


