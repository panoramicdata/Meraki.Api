namespace Meraki.Api.Data;

/// <summary>
/// A test to be created
/// </summary>
[DataContract]
public class ThousandEyesNetworkTest
{
	/// <summary>
	/// Network
	/// </summary>
	[DataMember(Name = "network")]
	public ThousandEyesNetworkTestNetwork Network { get; set; } = new();

	/// <summary>
	/// Thousand Eye test template object, maximun size: 1000
	/// </summary>
	[DataMember(Name = "template")]
	public ThousandEyesNetworkTestTemplate Template { get; set; } = new();
}
