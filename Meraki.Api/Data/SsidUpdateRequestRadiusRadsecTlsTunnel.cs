namespace Meraki.Api.Data;

/// <summary>
/// UpdateNetworkSsidRadiusRadsecTlsTunnel - Undocumented
/// </summary>
[DataContract]
public class SsidUpdateRequestRadiusRadsecTlsTunnel
{
	/// <summary>
	/// timeout - Undocumented
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "timeout")]
	public int? Timeout { get; set; }
}
