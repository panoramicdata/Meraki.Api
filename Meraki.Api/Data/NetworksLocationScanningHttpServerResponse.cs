namespace Meraki.Api.Data;

/// <summary>
/// Response for the GetNetworkLocationScanningHttpServersAsync and  UpdateNetworkLocationScanningHttpServersAsync methods
/// </summary>
[DataContract]
public class NetworksLocationScanningHttpServerResponse
{
	/// <summary>
	/// List of location scanning endpoints
	/// </summary>
	[DataMember(Name = "endpoints")]
	[ApiAccess(ApiAccess.Read)]
	public List<NetworksLocationScanningHttpServerEndpoint>? Endpoints { get; set; }
}
