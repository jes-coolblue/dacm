using System.Text.Json;
using DACM.Models;

namespace DACM.Repositories
{
	public class Repository : IRepository
	{
		private readonly string _assetMetadataPath = "Data/AssetMetadata.json";

		public async Task<List<Asset>> GetAssetAsync()
		{
			var json = await File.ReadAllTextAsync(_assetMetadataPath);
			var result = JsonSerializer.Deserialize<List<Asset>>(json);
			if (result == null)
			{
				return [];
			}
			else
			{
				return result;
			}
		}



	}
}
