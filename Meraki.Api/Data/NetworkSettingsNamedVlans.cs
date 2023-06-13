namespace Meraki.Api.Data;

/// <summary>
///  hash of Named VLANs options applied to the Network.
/// </summary>
[DataContract]
public class NetworkSettingsNamedVlans
{
	/// <summary>
	/// Enables / disables Named VLANs on the Network.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }
}
