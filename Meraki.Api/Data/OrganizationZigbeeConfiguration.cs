namespace Meraki.Api.Data;

/// <summary>
/// Organization Zigbee Configuration
/// </summary>
[DataContract]
public class OrganizationZigbeeConfiguration
{
	/// <summary>
	/// If Zigbee is enabled for the network
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }

	/// <summary>
	/// Default Settings for the MRs in network
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "defaults")]
	public OrganizationZigbeeDefaults Defaults { get; set; } = new();

	/// <summary>
	/// Device details setup the IoT controller
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "iotController")]
	public OrganizationZigbeeIotController IotController { get; set; } = new();

	/// <summary>
	/// Lock Management Details
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "lockManagement")]
	public OrganizationZigbeeLockManagement LockManagement { get; set; } = new();

	/// <summary>
	/// Network details
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "network")]
	public OrganizationZigbeeNetwork Network { get; set; } = new();
}
