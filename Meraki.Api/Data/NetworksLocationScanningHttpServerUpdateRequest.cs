namespace Meraki.Api.Data;

/// <summary>
/// Represents a request for the UpdateNetworkLocationScanningHttpServersAsync method
/// </summary>
[DataContract]
public class NetworksLocationScanningHttpServerUpdateRequest
{
	/// <summary>
	/// A set of http server configurations
	/// </summary>
	[DataMember(Name = "endpoints")]
	public NetworksLocationScanningHttpServerRequestEndpoints? Endpoints { get; set; }
}
