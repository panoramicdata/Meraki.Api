namespace Meraki.Api.Data;

/// <summary>
/// Catalyst access point detail
/// </summary>
[DataContract]
public class OrganizationWirelessDevicesWirelessControllersByDeviceDetail
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
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "value")]
	public string Value { get; set; } = string.Empty;
}