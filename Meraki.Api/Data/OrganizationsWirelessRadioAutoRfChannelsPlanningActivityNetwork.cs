namespace Meraki.Api.Data;

/// <summary>
/// Network data
/// </summary>
[DataContract]
public class OrganizationsWirelessRadioAutoRfChannelsPlanningActivityNetwork
{
	/// <summary>
	/// Network id
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Network name
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// List of custom tags for the network.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "tags")]
	public List<string> Tags { get; set; } = [];
}