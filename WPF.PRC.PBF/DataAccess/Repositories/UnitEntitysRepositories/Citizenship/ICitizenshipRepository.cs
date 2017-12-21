using Catel.Data.Repositories;

namespace WPF.PRC.PBF
{
    public interface ICitizenshipRepository : IEntityCustomRepository<Citizenship, long>
    {
        Citizenship AddIfNotExist(Citizenship entity);
    }
}