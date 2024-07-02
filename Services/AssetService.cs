using DACM.Models;
using DACM.Repositories;
using DACM.Cache;

namespace DACM.Services
{
	public class AssetService : IAssetService
    {
        private readonly IRepository _metadataRepository;
        private readonly ICacheService _cacheService;

        public AssetService(IRepository metadataRepository, ICacheService cacheService)
        {
            _metadataRepository = metadataRepository;
            _cacheService = cacheService;
        }

        public async Task<List<Asset>> List()
        {
            return await _metadataRepository.GetAssetAsync();
        }

        public async Task<Asset?> GetById(string assetId)
        {
            var assets = await _metadataRepository.GetAssetAsync();
            return assets.Find(asset => asset.AssetId == assetId);
        }

    }
}
