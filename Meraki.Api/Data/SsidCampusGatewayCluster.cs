namespace Meraki.Api.Data;

/// <summary>
/// The campus gateway cluster an SSID is assigned to
/// </summary>
[DataContract]
public class SsidCampusGatewayCluster
{
	/// <summary>
	/// ID of the campus gateway cluster
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "id")]
	public string? Id { get; set; }
}
