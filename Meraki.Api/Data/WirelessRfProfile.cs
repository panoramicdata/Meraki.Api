namespace Meraki.Api.Data;

/// <summary>
/// CreateNetworkWirelessRfProfile
/// </summary>
[DataContract]
public class WirelessRfProfile : WirelessRfProfileCreateUpdateRequest
{
	/// <summary>
	/// The Id
	/// </summary>
	[ApiKey]
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	///	Network id
	/// </summary>
	[ApiForeignKey(typeof(Network))]
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "networkId")]
	public string NetworkId { get; set; } = string.Empty;
}
