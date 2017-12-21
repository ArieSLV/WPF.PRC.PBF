using Catel.Data.Repositories;

namespace WPF.PRC.PBF
{
    public interface IEntityCustomRepository<TEntity, TPrimaryKey> : IEntityRepository<TEntity, TPrimaryKey> where TEntity: class
    {
        
    }
}