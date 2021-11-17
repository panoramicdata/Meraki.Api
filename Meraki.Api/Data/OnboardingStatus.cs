namespace Meraki.Api.Data;

/// <summary>
/// Onboarding status
/// </summary>
[DataContract]
public class OnboardingStatus
{
	/// <summary>
	/// Network id
	/// </summary>
	[DataMember(Name = "networkId")]
	public string NetworkId { get; set; } = string.Empty;

	/// <summary>
	/// Serial
	/// </summary>
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// Status
	/// </summary>
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	/// <summary>
	/// Updated at
	/// </summary>
	[DataMember(Name = "updatedAt")]
	public DateTime UpdatedAt { get; set; }
}
