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
		public string? AssetId { get; set; }
		
		/// <summary>
		/// Any comments associated with the asset
		/// </summary>
		public string? Comments { get; set; }

		/// <summary>
		/// The name of the user who created the asset
		/// </summary>
		public string? CreatedBy { get; set; }
		
		/// <summary>
		/// A short description of the asset
		/// </summary>
		public string? Description { get; set; }
		
		/// <summary>
		/// The file format of the asset
		/// </summary>
		public FileFormat? FileFormat { get; set; }
		
		/// <summary>
		/// The size of the asset in bytes
		/// </summary>
		public int? FileSize { get; set; }
		
		/// <summary>
		/// The display name of the asset
		/// </summary>
		public string? Name { get; set; }
		
		/// <summary>
		/// The uri of the asset
		/// </summary>
		public string? Path { get; set; }
		
		/// <summary>
		/// The uri of the preview of the asset
		/// </summary>
		public string? Preview { get; set; }
		
		/// <summary>
		/// The status of the asset
		/// </summary>
		public string? Status { get; set; }
		
		/// <summary>
		/// The timestamp of the last change to the asset.
		/// UTC time in ISO 8601 format.
		/// </summary>
		public DateTime? Timestamp { get; set; }
		
		/// <summary>
		/// The username of the user who last updated the asset
		/// </summary>
		public string? UserName { get; set; }
		
		/// <summary>
		/// Version number of the asset. Is incremented with each change to the asset.
		/// </summary>
		public string? VersionNumber { get; set; }
	}
}
