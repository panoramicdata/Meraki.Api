namespace Meraki.Api.Data;

/// <summary>
/// Replacment to perform
/// </summary>
[DataContract]
public class OrganizationInventorySwapCreateRequestSwap
{
	/// <summary>
	/// What action to perform on devices.old after the device cloning is complete. 'remove from network' will return the device to inventory, while 'release from organization inventory' will free up the license attached to the device. enum = ["release from organization inventory", "remove from network"]
	/// </summary>
	[DataMember(Name = "afterAction")]
	public string AfterAction { get; set; } = string.Empty;

	/// <summary>
	/// The devices involved in the swap.
	/// </summary>
	[DataMember(Name = "devices")]
	public OrganizationInventorySwapCreateRequestSwapDevices Devices { get; set; } = new();
}
