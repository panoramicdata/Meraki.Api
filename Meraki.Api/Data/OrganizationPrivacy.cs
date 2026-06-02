namespace Meraki.Api.Data;

/// <summary>
/// Organization privacy settings
/// </summary>
[ApiAccessReadOnlyClass]
[DataContract]
public class OrganizationPrivacy
{
	/// <summary>
	/// Default privacy settings
	/// </summary>
	[DataMember(Name = "byDefault")]
	public OrganizationPrivacyByDefault ByDefault { get; set; } = new();
}