namespace Meraki.Api.Data;

/// <summary>
/// SmInstallAppsRequest
/// </summary>
[DataContract]
public class SmInstallAppsRequest
{
	/// <summary>
	/// By default, installation of an app which is believed to already be present on the device will be skipped. If you'd like to force the installation of the app, set this parameter to true.
	/// </summary>
	[DataMember(Name = "force")]
	[ApiAccess(ApiAccess.Create)]
	public bool? Force { get; set; }

	/// <summary>
	/// Ids of applications to be installed
	/// </summary>
	[DataMember(Name = "appIds")]
	[ApiAccess(ApiAccess.Create)]
	public List<string> AppIds { get; set; } = [];
}
