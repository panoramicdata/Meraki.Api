namespace Meraki.Api.Data;

/// <summary>
/// Network this door lock is connected to
/// </summary>
[DataContract]
public class OrganizationZigbeeDoorLockDetailedNetwork
{
	/// <summary>
	/// Network Id
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Network name
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;
}
