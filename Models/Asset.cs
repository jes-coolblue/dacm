namespace DACM.Models
{
	/// <summary>
	/// Represents an asset.
	/// An asset is a digital content file that can be used in a campaign.
	/// </summary>
	public class Asset
	{
		/// <summary>
		/// The id of the asset.
		/// </summary>
		public string? assetId { get; set; }
		
		/// <summary>
		/// Any comments associated with the asset
		/// </summary>
		public string? comments { get; set; }

		/// <summary>
		/// The name of the user who created the asset
		/// </summary>
		public string? createdBy { get; set; }
		
		/// <summary>
		/// A short description of the asset
		/// </summary>
		public string? description { get; set; }
		
		/// <summary>
		/// The file format of the asset
		/// </summary>
		//TODO: Change to enum
		public string? fileFormat { get; set; }
		
		/// <summary>
		/// The size of the asset in bytes
		/// </summary>
		public int? fileSize { get; set; }
		
		/// <summary>
		/// The display name of the asset
		/// </summary>
		public string? name { get; set; }
		
		/// <summary>
		/// The uri of the asset
		/// </summary>
		public string? path { get; set; }
		
		/// <summary>
		/// The uri of the preview of the asset
		/// </summary>
		public string? preview { get; set; }
		
		/// <summary>
		/// The status of the asset
		/// </summary>
		public string? status { get; set; }
		
		/// <summary>
		/// The timestamp of the last change to the asset.
		/// UTC time in ISO 8601 format.
		/// </summary>
		public DateTime? timestamp { get; set; }
		
		/// <summary>
		/// The username of the user who last updated the asset
		/// </summary>
		public string? userName { get; set; }
		
		/// <summary>
		/// Version number of the asset. Is incremented with each change to the asset.
		/// </summary>
		public string? versionNumber { get; set; }
	}
}
