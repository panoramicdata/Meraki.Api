namespace Meraki.Api.Data;

/// <summary>
/// Object for RADIUS Settings
/// </summary>
[DataContract]
public class Radius
{
	/// <summary>
	/// Critical auth settings for when authentication is rejected by the RADIUS server
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "criticalAuth")]
	public CriticalAuth CriticalAuth { get; set; } = new();
}
