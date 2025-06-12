namespace Meraki.Api.Data;

/// <summary>
/// Threshold for a network
/// </summary>
[DataContract]
public class OrganizationInsightApplicationThresholdsByNetworkItem
{
	/// <summary>
	/// Number of useful information bits delivered over a network per unit of time
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "goodput")]
	public int Goodput { get; set; }

	/// <summary>
	/// Duration of the response, in milliseconds
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "networkId")]
	public int ResponseDuration { get; set; }

	/// <summary>
	/// Network identifier
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "networkId")]
	public string NetworkId { get; set; } = string.Empty;
}