using System.Threading.Tasks;
using ContentDistributionApp.Models;

namespace ContentDistributionApp.Services
{
    public interface IContentService
    {

        Task<List<Asset>> GetAssetAsync();
		Task<Asset?> GetAssetByIdAsync(string assetId);
		Task<Asset?> GetAssetMetadataByIdAsync(string assetId);
    }
}
