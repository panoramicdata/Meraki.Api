using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// Settings
/// </summary>
[DataContract]
public class AdaptivePolicySettings
{
	/// <summary>
	/// Enabled networks
	/// </summary>
	[DataMember(Name = "enabledNetworks")]
	public List<string> EnabledNetworks { get; set; } = new();
}
