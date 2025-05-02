namespace Meraki.Api.Data;
/// <summary>
/// SmUninstallAppsRequest
/// </summary>
[DataContract]
public class SmUninstallAppsRequest
{
	/// <summary>
	/// Ids of applications to be uninstalled
	/// </summary>
	[DataMember(Name = "appIds")]
	[ApiAccess(ApiAccess.Create)]
	public List<string> AppIds { get; set; } = [];
}
