using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using ContentDistributionApp.Models;

namespace ContentDistributionApp.Repositories
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
