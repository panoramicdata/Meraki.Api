using Meraki.Api.Attributes;
using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// The bandwidth settings for clients bound to your group policy.
/// </summary>
[DataContract]
public class Bandwidth
{
	/// <summary>
	/// Gets or Sets Settings
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "settings")]
	public Setting Settings { get; set; }
	/// <summary>
	/// Gets or Sets BandwidthLimits
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "bandwidthLimits")]
	public BandwidthLimit BandwidthLimits { get; set; } = new();
}
