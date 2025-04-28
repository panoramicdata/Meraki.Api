namespace Meraki.Api.Data;
/// <summary>
/// SmUninstallAppsRequest
/// </summary>
public class SmUninstallAppsRequest
{
	/// <summary>
	/// Ids of applications to be uninstalled
	/// </summary>
	[DataMember(Name = "appIds")]
	public List<string> AppIds { get; set; } = [];
}
