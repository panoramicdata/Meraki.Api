namespace Meraki.Api.Data;

/// <summary>
/// Network to which the sensor belongs.
/// </summary>
[DataContract]
public class OrganizationSensorReadingsHistoryByIntervalItemNetwork
{
	/// <summary>
	/// ID of the network.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Name of the network.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;
}