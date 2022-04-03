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
	[ApiAccess(ApiAccess.Read)]
	[ApiForeignKey(typeof(Network))]
	[DataMember(Name = "networkId")]
	public string NetworkId { get; set; } = string.Empty;

	/// <summary>
	/// Serial
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// Status
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	/// <summary>
	/// Updated at
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "updatedAt")]
	public DateTime UpdatedAt { get; set; }
}
