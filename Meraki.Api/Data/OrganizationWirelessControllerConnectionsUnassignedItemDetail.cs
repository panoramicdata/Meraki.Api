namespace Meraki.Api.Data;

/// <summary>
/// Catalyst access point details
/// </summary>
[DataContract]
public class OrganizationWirelessControllerConnectionsUnassignedItemDetail
{
	/// <summary> 
	/// Item name
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Item value
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "value")]
	public string Value { get; set; } = string.Empty;
}