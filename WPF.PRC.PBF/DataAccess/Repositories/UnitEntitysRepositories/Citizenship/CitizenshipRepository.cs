using System.Data.Entity;
using System.Linq;


namespace WPF.PRC.PBF
{
    internal class CitizenshipRepository : EntityCustomRepository<Citizenship, long>, ICitizenshipRepository
    {
        public CitizenshipRepository(DbContext dbContext) : base(dbContext)
        {

        }

        public Citizenship AddIfNotExist(Citizenship entity)
        {
            var query = GetQuery(x => x.Value == entity.Value);

            if (query.FirstOrDefault() != null) return query.First();

            Add(entity);
            return entity;
        }
    }
}
