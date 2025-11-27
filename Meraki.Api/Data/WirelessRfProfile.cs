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
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	///	Network id
	/// </summary>
	[ApiForeignKey(typeof(Network))]
	[DataMember(Name = "networkId")]
	public string NetworkId { get; set; } = string.Empty;

	/// <summary>
	///	afcEnabled - appears to be informational only as API doesn't mention this on a create/update model
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "afcEnabled")]
	public bool? AfcEnabled { get; set; }

	/// <summary>
	/// Undocumented
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "antennas")]
	public object? Antennas { get; set; }
}
