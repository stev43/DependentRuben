using ROG_6.Model.Repo.Interfaces;

namespace ROG_6.Model.Repo
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TamaContext _context;

        public UnitOfWork(TamaContext context)
        {
            _context = context;
            Tamagotchis = new TamagotchiRepository(_context);
        }

        public ITamagotchiRepository Tamagotchis { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}