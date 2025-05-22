namespace Meraki.Api.Data;

/// <summary>
/// SecureConnectDestinations
/// </summary>
[DataContract]
public class SecureConnectDestinations
{
	/// <summary>
	/// The pagination information for the response.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public SecureConnectReponseMeta Meta { get; set; } = new();

	/// <summary>
	/// The status information for the response.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public SecureConnectRequestStatus Status { get; set; } = new();

	/// <summary>
	/// The list of destination lists.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "data")]
	public List<SecureConnectDestination> Data { get; set; } = [];
}
