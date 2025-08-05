namespace Meraki.Api.Data;

/// <summary>
/// Network primary MX device firmware
/// </summary>
[DataContract]
public class ThousandEyesNetworkSupportedDeviceFirmware
{
	/// <summary>
	/// Network primary MX device firmware current version
	/// </summary> 
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "currentVersion")]
	public ThousandEyesNetworkSupportedDeviceFirmwareCurrentVersion CurrentVersion { get; set; } = new();
}
