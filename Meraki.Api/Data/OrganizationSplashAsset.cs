namespace Meraki.Api.Data;

/// <summary>
/// Organization Splash Asset
/// </summary>
[DataContract]
public class OrganizationSplashAsset : NamedIdentifiedItem
{
	/// <summary>
	/// Splash theme asset file date base64 encoded
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "fileData")]
	public string FileData { get; set; } = string.Empty;
}
