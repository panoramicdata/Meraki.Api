namespace Meraki.Api.Data;

/// <summary>
/// Sensor Connect major and minor assignment settings - Undocumented, observed in live API responses only
/// </summary>
[DataContract]
public class NetworkBluetoothSettingsSensorConnectAssignment
{
	/// <summary>
	/// The assignment mode, for example 'non-unique'
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "mode")]
	public string? Mode { get; set; }
}
