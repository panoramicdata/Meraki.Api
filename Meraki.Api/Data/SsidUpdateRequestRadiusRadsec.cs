namespace Meraki.Api.Data;

/// <summary>
/// UpdateNetworkSsidRadiusRadsec
/// </summary>
[DataContract]
public class SsidUpdateRequestRadiusRadsec
{
	/// <summary>
	/// RADSec TLS tunnel settings
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "tlsTunnel")]
	public SsidUpdateRequestRadiusRadsecTlsTunnel? TlsTunnel { get; set; }
}
