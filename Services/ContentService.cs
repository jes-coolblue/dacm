using System.Threading.Tasks;
using ContentDistributionApp.Models;
using ContentDistributionApp.Repositories;
using ContentDistributionApp.Cache;

namespace ContentDistributionApp.Services
{
    public class ContentService : IContentService
    {
        private readonly IRepository _metadataRepository;
        private readonly ICacheService _cacheService;

        public ContentService(IRepository metadataRepository, ICacheService cacheService)
        {
            _metadataRepository = metadataRepository;
            _cacheService = cacheService;
        }

        public async Task<List<Asset>> GetAssetAsync()
        {
            return await _metadataRepository.GetAssetAsync();
        }

        public async Task<Asset?> GetAssetByIdAsync(string assetId)
        {
            var assets = await _metadataRepository.GetAssetAsync();
            return assets.Find(asset => asset.AssetId == assetId);
        }
        public async Task<Asset?> GetAssetMetadataByIdAsync(string assetId)
        {
            throw new System.NotImplementedException();	
        }
    }
}
