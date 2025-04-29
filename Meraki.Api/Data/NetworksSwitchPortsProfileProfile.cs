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
	public bool? Enabled { get; set; }

	/// <summary>
	/// The ID of the associated port profile
	/// </summary>
	[DataMember(Name = "id")]
	public string? Id { get; set; }
}
