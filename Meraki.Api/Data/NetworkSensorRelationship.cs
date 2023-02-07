namespace Meraki.Api.Data;

/// <summary>
/// A list of sensor relationships by network
/// </summary>
[DataContract]
public class NetworkSensorRelationship
{
	/// <summary>
	/// A sensor or gateway device in the network
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "device")]
	public NetworkSensorRelationshipDevice Device { get; set; } = new();

	/// <summary>
	/// An object describing the relationships defined between the device and other devices
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "relationships")]
	public NetworkSensorRelationshipRelationships Relationships { get; set; } = new();
}