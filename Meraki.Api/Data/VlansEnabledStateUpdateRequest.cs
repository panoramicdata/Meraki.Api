namespace Meraki.Api.Data;

/// <summary>
/// Vlans Enabled State
/// </summary>
[DataContract]
public class VlansEnabledState
{
	/// <summary>
	/// Boolean indicating whether to enable (true) or disable (false) VLANs for the network
	/// </summary>
	/// <value>Boolean indicating whether to enable (true) or disable (false) VLANs for the network</value>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "vlansEnabled")]
	public bool? Enabled { get; set; }
}
