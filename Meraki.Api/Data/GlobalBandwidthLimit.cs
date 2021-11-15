using Meraki.Api.Attributes;
using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// Global per-client bandwidth limit
/// </summary>
[DataContract]
public class GlobalBandwidthLimit
{
	/// <summary>
	/// The upload bandwidth limit in Kbps. (0 represents no limit.)
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "limitUp")]
	public int LimitUp { get; set; }

	/// <summary>
	/// The download bandwidth limit in Kbps. (0 represents no limit.)
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "limitDown")]
	public int LimitDown { get; set; }
}
