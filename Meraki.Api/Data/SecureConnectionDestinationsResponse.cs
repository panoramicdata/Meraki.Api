namespace Meraki.Api.Data;

/// <summary>
/// SecureConnectionDestinationCreateResponse
/// </summary>
[DataContract]
public class SecureConnectionDestinationsResponse
{
	/// <summary>
	/// The pagination information for the response.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "meta")]
	public SecureConnectDestinationList Meta { get; set; } = new();

	/// <summary>
	/// The status information for the response.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public SecureConnectRequestStatus Status { get; set; } = new();
}
