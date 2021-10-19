using Meraki.Api.Attributes;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Security settings of the MQTT broker.
	/// </summary>
	[DataContract]
	public class MqttSecurityCreateUpdateRequest
	{
		/// <summary>
		/// Security protocol of the MQTT broker.
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "mode")]
		public string Mode { get; set; } = string.Empty;

		/// <summary>
		/// TLS settings of the MQTT broker.
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "tls")]
		public MqttTlsSettingCreateUpdateRequest TlsSetting { get; set; } = new();
	}
}