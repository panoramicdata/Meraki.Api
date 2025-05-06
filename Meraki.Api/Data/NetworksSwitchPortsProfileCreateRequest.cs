namespace Meraki.Api.Data;

/// <summary>
/// Networks Switch Ports Profile Create Request
/// </summary>
[DataContract]
public class NetworksSwitchPortsProfileCreateRequest
{
	/// <summary>
	/// Text describing the profile
	/// </summary>
	[DataMember(Name = "description")]
	[ApiAccess(ApiAccess.Create)]
	public string? Description { get; set; }

	/// <summary>
	/// The name of the profile
	/// </summary>
	[DataMember(Name = "name")]
	[ApiAccess(ApiAccess.Create)]
	public string? Name { get; set; }

	/// <summary>
	/// Configuration settings for port profile
	/// </summary>
	[DataMember(Name = "port")]
	[ApiAccess(ApiAccess.Create)]
	public NetworksSwitchPortsProfilePort? Port { get; set; }
}
