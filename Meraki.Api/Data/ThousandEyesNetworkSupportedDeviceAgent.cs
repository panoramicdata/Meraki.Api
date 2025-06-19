namespace Meraki.Api.Data;

/// <summary>
/// ThousandEyes agent
/// </summary>
[DataContract]
public class ThousandEyesNetworkSupportedDeviceAgent
{
	/// <summary>
	/// Indicates if network has ThousandEyes agent installed
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "isInstalled")]
	public bool IsInstalled { get; set; }
}