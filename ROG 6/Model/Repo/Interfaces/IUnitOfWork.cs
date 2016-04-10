using System;

namespace ROG_6.Model.Repo.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ITamagotchiRepository Tamagotchis { get; }
        int Complete();
    }
}
