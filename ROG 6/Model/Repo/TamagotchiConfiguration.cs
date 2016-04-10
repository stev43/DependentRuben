using System.Data.Entity.ModelConfiguration;

namespace ROG_6.Model.Repo
{
    public class TamagotchiConfiguration : EntityTypeConfiguration<Tamagotchi>
    {

        public TamagotchiConfiguration()
        {
            Property(c => c.name)
                .IsRequired()
                .HasMaxLength(256);

            Property(c => c.hunger)
                .IsRequired();

            Property(c => c.sleep)
                .IsRequired();

            Property(c => c.boredom)
                .IsRequired();

            Property(c => c.health)
                .IsRequired();

            Property(c => c.lastAcces);

            HasRequired(c => c.status);
        }
    }
}
