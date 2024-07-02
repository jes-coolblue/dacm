namespace ContentDistributionApp.Models
{	
	/// <summary>
	/// This enum represents the status of an asset.
	/// </summary>
	public enum AssetStatus
	{
		/// <summary>
		/// This is the default status for a new asset.
		/// </summary>
		InProgress,
		/// <summary>
		/// This status indicates that the asset has been approved
		/// and can be used in a campaign.
		/// </summary>
		Approved,
		/// <summary>
		/// Once an asset has expired, it can no longer be used in a campaign.
		/// </summary>
		Expired
	}
}
