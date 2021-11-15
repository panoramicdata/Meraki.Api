namespace Meraki.Api.Data;

/// <summary>
/// Update onboarding status
/// </summary>
[DataContract]
public class UpdateOnboardingStatus
{
	/// <summary>
	/// Serial of camera
	/// </summary>
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// Note whether credentials were sent successfully
	/// </summary>
	[DataMember(Name = "wirelessCredentialsSent")]
	public bool WirelessCredentialsSent { get; set; }
}
