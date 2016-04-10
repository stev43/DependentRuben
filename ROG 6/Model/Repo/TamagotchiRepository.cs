using ROG_6.Model.Repo.Interfaces;

namespace ROG_6.Model.Repo
{
    class TamagotchiRepository : Repository<Tamagotchi>, ITamagotchiRepository
    {
        public TamagotchiRepository(TamaContext context)
            : base(context)
        {
        }


        public TamaContext TamaContext
        {
            get { return Context as TamaContext; }
        }
    }
}
