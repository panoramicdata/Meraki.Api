namespace Meraki.Api.Data;

/// <summary>
/// Ping request parameters
/// </summary>
[DataContract]
public class OrganizationsInsightSpeedTestResultRequest
{
	/// <summary>
	/// Uplink name
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "interface")]
	public string Interface { get; set; } = string.Empty;

	/// <summary>
	/// Device serial number
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;
}