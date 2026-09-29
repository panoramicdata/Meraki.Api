namespace Meraki.Api.Data;

/// <summary>
/// Umbrella configuration returned when connecting an Umbrella account
/// </summary>
[DataContract]
public class NetworkUmbrellaAccountConnectResponseUmbrella
{
	/// <summary>
	/// Organization details
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "organization")]
	public NetworkUmbrellaAccountConnectResponseUmbrellaOrganization? Organization { get; set; }
}
