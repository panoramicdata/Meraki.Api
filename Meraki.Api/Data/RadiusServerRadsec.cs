namespace Meraki.Api.Data;

/// <summary>
/// RADSEC settings for a RADIUS server - Undocumented, observed in responses only
/// </summary>
[DataContract]
public class RadiusServerRadsec
{
	/// <summary>
	/// Whether RADSEC is enabled for the RADIUS server
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }
}
