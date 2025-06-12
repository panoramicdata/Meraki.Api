namespace Meraki.Api.Data;

/// <summary>
/// ThousandEyes Network Update Request
/// </summary>
[DataContract]
public class ThousandEyesNetworkUpdateRequest
{
	/// <summary>
	/// Whether or not the ThousandEyes agent is enabled for the network.
	/// </summary>
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }
}
