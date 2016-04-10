using System.Data.Entity;

namespace ROG_6.Model.Repo
{
    public class TamaContext : DbContext
    {
        public TamaContext()
            : base("name=GotchiDb")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<Tamagotchi> Tamagotchis { get; set; }
        public virtual DbSet<Status> Status { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new TamagotchiConfiguration());
        }
    }
}
