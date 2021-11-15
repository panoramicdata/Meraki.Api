using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// UpdateNetworkClientSplashAuthorizationStatus
/// </summary>
[DataContract]
public class ClientSplashAuthorizationStatusUpdateRequest
{
	/// <summary>
	/// The target SSIDs. Each SSID must be enabled and must have Click-through splash enabled. For each SSID where isAuthorized is true, the expiration time will automatically be set according to the SSID&#39;s splash frequency. Not all networks support configuring all SSIDs
	/// </summary>
	/// <value>The target SSIDs. Each SSID must be enabled and must have Click-through splash enabled. For each SSID where isAuthorized is true, the expiration time will automatically be set according to the SSID&#39;s splash frequency. Not all networks support configuring all SSIDs</value>
	[DataMember(Name = "ssids")]
	public Dictionary<string, GeneratedObject10> Ssids { get; set; } = new();
}
