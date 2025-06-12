namespace Meraki.Api.Data;

/// <summary>
/// The devices involved in the swap.
/// </summary>
[DataContract]
public class OrganizationInventorySwapCreateRequestSwapDevices
{
	/// <summary>
	/// The serial of the device that the old device's settings will be cloned to.
	/// </summary>
	[DataMember(Name = "new")]
	public string New { get; set; } = string.Empty;

	/// <summary>
	/// The serial of the device to be cloned.
	/// </summary>
	[DataMember(Name = "old")]
	public string Old { get; set; } = string.Empty;
}