namespace Meraki.Api.Data;

/// <summary>
/// Authentication settings of the MQTT broker
/// </summary>
[DataContract]
public class MqttAuthentication
{
	/// <summary>
	/// UserName
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "userName")]
	public string UserName { get; set; } = string.Empty;
}
