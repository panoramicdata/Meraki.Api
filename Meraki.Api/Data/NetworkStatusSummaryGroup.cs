namespace Meraki.Api.Data;

/// <summary>
/// Network group membership
/// </summary>
[DataContract]
public class NetworkStatusSummaryGroup
{
	/// <summary>
	/// ID of the network group
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string? Id { get; set; }
}
