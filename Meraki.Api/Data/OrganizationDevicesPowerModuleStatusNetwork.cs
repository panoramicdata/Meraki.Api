namespace Meraki.Api.Data;

/// <summary>
/// Network info.
/// </summary>
[DataContract]
public class OrganizationDevicesPowerModuleStatusNetwork
{
	/// <summary>
	/// ID for the network that the device is associated with.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;
}