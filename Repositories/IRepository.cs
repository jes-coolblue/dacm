// using System.Collections.Generic;
// using System.Threading.Tasks;
using DACM.Models;

namespace DACM.Repositories
{
    public interface IRepository
    {

        Task<List<Asset>> GetAssetAsync();
    }
}
