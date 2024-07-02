using Microsoft.AspNetCore.Mvc;
using DACM.Services;
using Swashbuckle.AspNetCore.Annotations;
using DACM.Models;

namespace DACM.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class AssetController : ControllerBase
	{
		private readonly IAssetService _contentService;

		public AssetController(IAssetService contentService)
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
		[SwaggerResponse(200, "List of assets", typeof(List<Asset>))]
		public async Task<IActionResult> List()
		{
			var assetMetadata = await _contentService.List();
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
		[SwaggerResponse(200, "An asset", typeof(Asset))]
		public async Task<IActionResult> GetById(string id)
		{
			var asset = await _contentService.GetById(id);
			if (asset == null)
			{
				return NotFound();
			}
			return Ok(asset);
		}
	}
}
