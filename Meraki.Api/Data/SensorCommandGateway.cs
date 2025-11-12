namespace Meraki.Api.Data;

/// <summary>
/// Sensor Command Gateway
/// </summary>
[DataContract]
public class SensorCommandGateway
{
	/// <summary>
	/// Gateway serial
	/// </summary>
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// Gateway name
	/// </summary>
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;
}
