namespace Meraki.Api.Data;

/// <summary>
/// Split tunnel
/// </summary>
[DataContract]
public class SplitTunnel
{
	/// <summary>
	/// Enabled
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }

	/// <summary>
	/// Rules
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "rules")]
	public List<SplitTunnelRule> Rules { get; set; } = [];
}
