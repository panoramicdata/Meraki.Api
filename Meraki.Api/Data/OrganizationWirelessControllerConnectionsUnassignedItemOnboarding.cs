namespace Meraki.Api.Data;

/// <summary>
/// AP onboarding details
/// </summary>
[DataContract]
public class OrganizationWirelessControllerConnectionsUnassignedItemOnboarding
{
	/// <summary>
	/// AP onboarding status and it's values are unregistered, registered, added to network and completed
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	/// <summary>
	/// Meraki onboarding support for the AP
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "isSupported")]
	public bool IsSupported { get; set; }

	/// <summary>
	/// AP onboarding errors in case of unregistered status
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "errors")]
	public List<string> Errors { get; set; } = [];
}