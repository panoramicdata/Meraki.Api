namespace Meraki.Api.Data;

/// <summary>
/// The devices involved in the swap
/// </summary>
[DataContract]
public class OrganizationInventorySwapResponseSwapDevices
{
	/// <summary>
	/// The device that will have settings cloned to
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "new")]
	public OOrganizationInventorySwapResponseSwapDevicesNew New { get; set; } = new();

	/// <summary>
	/// The device that will be cloned
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "old")]
	public OrganizationInventorySwapResponseSwapDevicesOld Old { get; set; } = new();
}
