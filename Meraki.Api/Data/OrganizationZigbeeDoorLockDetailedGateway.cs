namespace Meraki.Api.Data;

/// <summary>
/// Gateway this door lock is connected to
/// </summary>
[DataContract]
public class OrganizationZigbeeDoorLockDetailedGateway
{
	/// <summary>
	/// MR Device Name
	/// </summary> 
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Gateway serial
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;
}