namespace Meraki.Api.Data;

/// <summary>
/// Profile attributes
/// </summary>
[DataContract]
public class NetworksSwitchPortsProfileProfile
{
	/// <summary>
	/// The status of static port profile on the port
	/// </summary>
	[DataMember(Name = "enabled")]
	[ApiAccess(ApiAccess.ReadWrite)]
	public bool? Enabled { get; set; }

	/// <summary>
	/// The ID of the associated port profile
	/// </summary>
	[DataMember(Name = "id")]
	[ApiAccess(ApiAccess.ReadWrite)]
	public string? Id { get; set; }
}
