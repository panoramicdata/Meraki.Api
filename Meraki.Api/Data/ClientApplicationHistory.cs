namespace Meraki.Api.Data;

/// <summary>
/// Application usage
/// </summary>
[DataContract]
public class ClientApplicationHistory
{
	/// <summary>
	/// Client id
	/// </summary>
	[DataMember(Name = "clientId")]
	public string ClientId { get; set; } = string.Empty;

	/// <summary>
	/// Client ip
	/// </summary>
	[DataMember(Name = "clientIp")]
	public string ClientIp { get; set; } = string.Empty;

	/// <summary>
	/// Client mac
	/// </summary>
	[DataMember(Name = "clientMac")]
	public string ClientMac { get; set; } = string.Empty;

	/// <summary>
	/// Application usage
	/// </summary>
	[DataMember(Name = "usageHistory")]
	public List<SubclassUsageHistory> UsageHistory { get; set; } = [];
}
