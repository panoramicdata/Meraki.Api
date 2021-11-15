using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// Device type group policies
/// </summary>
[DataContract]
public class DeviceTypeGroupPolicies
{
	/// <summary>
	/// Enabled
	/// </summary>
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }

	/// <summary>
	/// Device type policies
	/// </summary>
	[DataMember(Name = "deviceTypePolicies")]
	public List<DeviceTypePolicies> DeviceTypePolicies { get; set; } = new();
}
