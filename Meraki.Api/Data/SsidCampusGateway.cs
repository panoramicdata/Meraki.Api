namespace Meraki.Api.Data;

/// <summary>
/// Campus gateway settings for an SSID. Only present when ipAssignmentMode is 'Campus Gateway'.
/// </summary>
[DataContract]
public class SsidCampusGateway
{
	/// <summary>
	/// The campus gateway cluster the SSID is assigned to
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "cluster")]
	public SsidCampusGatewayCluster? Cluster { get; set; }
}
