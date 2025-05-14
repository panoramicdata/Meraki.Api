namespace Meraki.Api.Data;

/// <summary>
/// Add scanning API receiver for network
/// </summary>
[DataContract]
public class WirelessReceiverNetworkSimple
{
	/// <summary>
	/// Network Id
	/// </summary> 
	[DataMember(Name = "id")]
	public string? Id { get; set; }
}