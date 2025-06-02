namespace Meraki.Api.Data;

/// <summary>
/// A device import to commit
/// </summary>
[DataContract]
public class OrganizationsInventoryOnboardingCloudMonitoringImportCreateRequestDevice
{
	/// <summary>
	/// Import ID from the Import operation
	/// </summary>
	[DataMember(Name = "deviceId")]
	public string DeviceId { get; set; } = string.Empty;

	/// <summary>
	/// Network Id
	/// </summary>
	[DataMember(Name = "networkId")]
	public string NetworkId { get; set; } = string.Empty;

	/// <summary>
	/// Device UDI certificate
	/// </summary>
	[DataMember(Name = "udi")]
	public string Udi { get; set; } = string.Empty;
}