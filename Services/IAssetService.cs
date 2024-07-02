using DACM.Models;

namespace DACM.Services
{
	public interface IAssetService
    {

        Task<List<Asset>> List();
		Task<Asset?> GetById(string assetId);
    }
}
