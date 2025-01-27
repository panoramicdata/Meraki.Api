namespace Meraki.Api.Data;

/// <summary>
/// DhcpEnforcedDeauthentication
/// </summary>
[DataContract]
public class DhcpEnforcedDeauthentication
{
	/// <summary>
	/// Undocumented - 2025-01-27
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }
}
