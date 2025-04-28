namespace Meraki.Api.Data;

/// <summary>
/// SmInstallAppsRequest
/// </summary>
public class SmInstallAppsRequest
{
	/// <summary>
	/// By default, installation of an app which is believed to already be present on the device will be skipped. If you'd like to force the installation of the app, set this parameter to true.
	/// </summary>
	[DataMember(Name = "force")]
	public bool? Force { get; set; }

	/// <summary>
	/// Ids of applications to be installed
	/// </summary>
	public List<string> AppIds { get; set; } = [];
}
