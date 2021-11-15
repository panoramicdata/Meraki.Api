namespace Meraki.Api.Data;

/// <summary>
/// TLS settings of the MQTT broker.
/// </summary>
[DataContract]
public class MqttTlsSetting
{
	/// <summary>
	/// Indicates whether the MQTT broker has a CaCertificate
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "hasCaCertificate")]
	public bool HasCaCertificate { get; set; }

	/// <summary>
	/// Whether the TLS hostname verification is enabled for the MQTT broker.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "verifyHostnames")]
	public bool VerifyHostnames { get; set; }
}
