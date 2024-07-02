using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using DACM.Services;

namespace DACM.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class ContentController : ControllerBase
	{
		private readonly IContentService _contentService;

		public ContentController(IContentService contentService)
		{
			_contentService = contentService;
		}

		/// <summary>
		/// Endpoint to get all assets
		/// </summary>
		/// <returns>
		/// A list of all assets
		/// </returns>
		[HttpGet("asset")]
		public async Task<IActionResult> GetAssetMetadata()
		{
			var assetMetadata = await _contentService.GetAssetAsync();
			if (assetMetadata == null)
			{
				return NotFound();
			}

			return Ok(assetMetadata);
		}

		/// <summary>
		/// Endpoint to get asset by id
		/// </summary>
		[HttpGet("asset/{id}")]
		public async Task<IActionResult> GetAssetById(string id)
		{
			var asset = await _contentService.GetAssetByIdAsync(id);
			if (asset == null)
			{
				return NotFound();
			}
			return Ok(asset);
		}

		/// <summary>
		/// Endpoint to get metadata for an asset
		/// </summary>
		[HttpGet("asset/{id}/metadata")]
		public async Task<IActionResult> GetAssetMetadataById(string id)
		{
			var asset = await _contentService.GetAssetByIdAsync(id);
			if (asset == null)
			{
				return NotFound();
			}
			return Ok(asset);
		}
		
	}
}
