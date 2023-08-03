namespace Meraki.Api.Data;

/// <summary>
/// Bonjour forwarding exception
/// </summary>
[DataContract]
public class SsidBonjourForwardingException
{
	/// <summary>
	/// If true, Bonjour forwarding exception is enabled on this SSID. Exception is required to enable L2 isolation and Bonjour forwarding to work together.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }
}
