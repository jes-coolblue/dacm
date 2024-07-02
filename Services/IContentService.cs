using System.Threading.Tasks;
using DACM.Models;

namespace DACM.Services
{
    public interface IContentService
    {

        Task<List<Asset>> GetAssetAsync();
		Task<Asset?> GetAssetByIdAsync(string assetId);
		Task<Asset?> GetAssetMetadataByIdAsync(string assetId);
    }
}
