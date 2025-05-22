namespace Meraki.Api.Data;

/// <summary>
/// The devices involved in the swap
/// </summary>
[DataContract]
public class OrganizationInventorySwapCreateResponseSwapDevices
{
	/// <summary>
	/// The device that will have settings cloned to
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "new")]
	public OrganizationInventorySwapCreateResponseSwapDevicesNew New { get; set; } = new();

	/// <summary>
	/// The device that will be cloned
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "old")]
	public OrganizationInventorySwapCreateResponseSwapDevicesOld Old { get; set; } = new();
}
