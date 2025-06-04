namespace Meraki.Api.Data;

/// <summary>
/// Network Umbrella Account Connect Request
/// </summary>
[DataContract]
public class NetworkUmbrellaAccountConnectRequest
{
	/// <summary>
	/// API key for the Umbrella account
	/// </summary>
	[DataMember(Name = "apiKey")]
	public string ApiKey { get; set; } = string.Empty;

	/// <summary>
	/// API secret for the Umbrella account
	/// </summary>
	[DataMember(Name = "apiSecret")]
	public string ApiSecret { get; set; } = string.Empty;
}
