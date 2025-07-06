namespace Meraki.Api.Data;

/// <summary>
/// Network Umbrella Account Connect Response
/// </summary>
[DataContract]
public class NetworkUmbrellaAccountConnectResponse
{
	/// <summary>
	/// Umbrella organization ID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "umbrellaOrganizationId")]
	public string UmbrellaOrganizationId { get; set; } = string.Empty;
}
