namespace Meraki.Api.Data;

/// <summary>
/// A HTTP Server Object
/// </summary>
public class NetworksLocationScanningHttpServerSimple
{
	/// <summary>
	/// A Shared Secret that will be included in POSTs sent to the HTTP server. This secret can be used to verify that the request was sent by Meraki
	/// </summary>
	[DataMember(Name = "sharedSecret")]
	public string? SharedSecret { get; set; }

	/// <summary>
	/// The URL of the HTTP server
	/// </summary>
	[DataMember(Name = "url")]
	public string? Url { get; set; }
}