namespace Meraki.Api.Data;

/// <summary>
/// Network Sensor Schedule
/// </summary>
[DataContract]
public class NetworkSensorSchedule
{
	/// <summary>
	/// Id
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Name
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;
}
