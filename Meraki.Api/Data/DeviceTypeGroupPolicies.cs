namespace Meraki.Api.Data;

/// <summary>
/// Device type group policies
/// </summary>
[DataContract]
public class DeviceTypeGroupPolicies
{
	/// <summary>
	/// If true, the SSID device type group policies are enabled.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }

	/// <summary>
	/// List of device type policies.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "deviceTypePolicies")]
	public List<DeviceTypePolicy> DeviceTypePolicies { get; set; } = new();
}
