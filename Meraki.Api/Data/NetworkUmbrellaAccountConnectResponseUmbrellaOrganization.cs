namespace Meraki.Api.Data;

/// <summary>
/// The Umbrella organization connected to a network
/// </summary>
[DataContract]
public class NetworkUmbrellaAccountConnectResponseUmbrellaOrganization
{
	/// <summary>
	/// The Umbrella organization ID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string? Id { get; set; }
}
