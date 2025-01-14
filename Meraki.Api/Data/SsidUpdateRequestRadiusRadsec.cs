namespace Meraki.Api.Data;

/// <summary>
/// UpdateNetworkSsidRadiusRadsec - Undocumented
/// </summary>
[DataContract]
public class SsidUpdateRequestRadiusRadsec
{
	/// <summary>
	/// tlsTunnel - Undocumented
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "tlsTunnel")]
	public SsidUpdateRequestRadiusRadsecTlsTunnel? TlsTunnel { get; set; }
}
