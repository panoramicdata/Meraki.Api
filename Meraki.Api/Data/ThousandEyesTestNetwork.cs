namespace Meraki.Api.Data;

/// <summary>
/// Network
/// </summary>
[DataContract]
public class ThousandEyesTestNetwork
{
	/// <summary>
	/// Network Id e.g. N_12345
	/// </summary>
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;
}