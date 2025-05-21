namespace Meraki.Api.Data;

/// <summary>
/// Network primary MX device firmware current version
/// </summary>
[DataContract]
public class ThousandEyesNetworkSupportedDeviceFirmwareCurrentVersion
{
	/// <summary>
	/// Network primary MX device firmware current version short name
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "shortName")]
	public string ShortName { get; set; } = string.Empty;
}