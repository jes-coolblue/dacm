using DACM.Models;

namespace DACM.Repositories
{
    public interface IRepository
    {

        Task<List<Asset>> GetAssetAsync();
    }
}
