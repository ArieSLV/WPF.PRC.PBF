using System.Data.Entity;
using Catel.Data.Repositories;

namespace WPF.PRC.PBF
{
    class EntityCustomRepository<TEntity, TPrimaryKey> : 
        EntityRepositoryBase<TEntity, TPrimaryKey>, 
        IEntityCustomRepository<TEntity, TPrimaryKey> 
        where TEntity : class, ISuggestable
    {
        public EntityCustomRepository(DbContext dbContext) : base(dbContext)
        {
        }

        
    }
}