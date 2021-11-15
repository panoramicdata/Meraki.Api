using Meraki.Api.Attributes;
using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// TLS settings of the MQTT broker.
/// </summary>
[DataContract]
public class MqttTlsSettingCreateUpdateRequest
{
	/// <summary>
	/// CA Certificate of the MQTT broker.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "caCertificate")]
	public string CaCertificate { get; set; } = string.Empty;

	/// <summary>
	/// Whether the TLS hostname verification is enabled for the MQTT broker.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "verifyHostnames")]
	public bool VerifyHostnames { get; set; }
}
