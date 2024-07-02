using System.Threading.Tasks;
using DACM.Models;
using DACM.Repositories;
using DACM.Cache;

namespace DACM.Services
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
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
		public async Task<Asset?> GetAssetMetadataByIdAsync(string assetId)
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
		{
            throw new System.NotImplementedException();	
        }
    }
}
