using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// Splash login attempts
/// </summary>
[DataContract]
public class SplashLoginAttempts
{
	/// <summary>
	/// Name
	/// </summary>
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Login
	/// </summary>
	[DataMember(Name = "login")]
	public string Login { get; set; } = string.Empty;

	/// <summary>
	/// SSID
	/// </summary>
	[DataMember(Name = "ssid")]
	public string Ssid { get; set; } = string.Empty;

	/// <summary>
	/// Login at
	/// </summary>
	[DataMember(Name = "loginAt")]
	public string LoginAt { get; set; } = string.Empty;

	/// <summary>
	/// Gateway device mac
	/// </summary>
	[DataMember(Name = "gatewayDeviceMac")]
	public string GatewayDeviceMac { get; set; } = string.Empty;

	/// <summary>
	/// Client mac
	/// </summary>
	[DataMember(Name = "clientMac")]
	public string ClientMac { get; set; } = string.Empty;

	/// <summary>
	/// Client id
	/// </summary>
	[DataMember(Name = "clientId")]
	public string ClientId { get; set; } = string.Empty;

	/// <summary>
	/// Authorization
	/// </summary>
	[DataMember(Name = "authorization")]
	public string Authorization { get; set; } = string.Empty;
}
