namespace Meraki.Api.Data;

/// <summary>
/// SecureConnectDestinationListCreateResponse
/// </summary>
[DataContract]
public class SecureConnectDestinationListResponse
{
	/// <summary>
	/// Data
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "data")]
	public SecureConnectDestinationList Data { get; set; } = new();

	/// <summary>
	/// The status information for the response.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public SecureConnectRequestStatus Status { get; set; } = new();
}
