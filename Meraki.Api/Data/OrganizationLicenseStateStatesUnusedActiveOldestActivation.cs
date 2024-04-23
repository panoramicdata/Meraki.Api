namespace Meraki.Api.Data;

/// <summary>
/// An organization licence state states unused active oldest activation
/// </summary>
[ApiAccessReadOnlyClass]
[DataContract]
public class OrganizationLicenseStateStatesUnusedActiveOldestActivation
{
	/// <summary>
	/// The number of licenses that activated on this date
	/// </summary>
	[DataMember(Name = "activeCount")]
	public int ActiveCount { get; set; }

	/// <summary>
	/// The oldest license activation date
	/// </summary>
	[DataMember(Name = "activationDate")]
	public DateTime ActivationDate { get; set; } = new();
}
