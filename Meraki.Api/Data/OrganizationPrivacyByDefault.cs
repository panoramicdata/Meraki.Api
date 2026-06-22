namespace Meraki.Api.Data;

/// <summary>
/// Default organization privacy settings
/// </summary>
[ApiAccessReadOnlyClass]
[DataContract]
public class OrganizationPrivacyByDefault
{
	/// <summary>
	/// Indicates whether privacy is enabled by default
	/// </summary>
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }
}