namespace Meraki.Api.Data;

/// <summary>
/// Network for the given utilization metrics.
/// </summary>
[DataContract]
public class OrganizationWirelessDevicesChannelUtilizationNetwork
{
	/// <summary>
	/// Network ID of the given utilization metrics.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;
}