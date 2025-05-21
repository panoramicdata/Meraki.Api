namespace Meraki.Api.Data;

/// <summary>
/// ThousandEyes Network Create Request
/// </summary>
[DataContract]
public class ThousandEyesNetworkCreateRequest
{
	/// <summary>
	/// Whether or not the ThousandEyes agent is enabled for the network.
	/// </summary>
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }

	/// <summary>
	/// Network that will have the ThousandEyes agent installed on.
	/// </summary>
	[DataMember(Name = "networkId")]
	public string NetworkId { get; set; } = string.Empty;

	/// <summary>
	/// An array of tests to be created
	/// </summary>
	[DataMember(Name = "tests")]
	public List<ThousandEyesTest>? Tests { get; set; }
}
