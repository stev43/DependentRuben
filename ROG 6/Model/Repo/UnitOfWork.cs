using ROG_6.Model.Repo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROG_6.Model.Repo
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TamaContext _context;

        public UnitOfWork(TamaContext context)
        {
            _context = context;
            Courses = new TamagotchiRepository(_context);
        }

        public ITamagotchiRepository Courses { get; private set; }

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
