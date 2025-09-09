namespace Meraki.Api.Data;

/// <summary>
/// Object for RADIUS Authentication Settings
/// </summary>
[DataContract]
public class RadiusAuthentication
{
	/// <summary>
	/// Authentication mode of the policy ( Open | Closed ) enum = ["Closed", "Open"]
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "mode")]
	public RadiusAuthenticationMode? Mode { get; set; }
}
