namespace Meraki.Api.Data;

/// <summary>
/// Organization Air Marshal Settings
/// </summary>
[DataContract]
public class AirMarshalSettings
{
	/// <summary>
	/// Allows clients to access rogue networks. Blocked by default. Valid values are 'allow', 'block'
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "defaultPolicy")]
	public string DefaultPolicy { get; set; } = string.Empty;

	/// <summary>
	/// The network ID
	/// </summary>
	[ApiForeignKey(typeof(Network))]
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "networkId")]
	public string NetworkId { get; set; } = string.Empty;

}
