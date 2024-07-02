// using System.Collections.Generic;
// using System.Threading.Tasks;
using ContentDistributionApp.Models;

namespace ContentDistributionApp.Repositories
{
    public interface IRepository
    {

        Task<List<Asset>> GetAssetAsync();
    }
}
