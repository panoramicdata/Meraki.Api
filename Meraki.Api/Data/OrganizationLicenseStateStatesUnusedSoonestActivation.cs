namespace Meraki.Api.Data;

/// <summary>
/// An organization licence state states unused soonest activation
/// </summary>
[ApiAccessReadOnlyClass]
[DataContract]
public class OrganizationLicenseStateStatesUnusedSoonestActivation
{
	/// <summary>
	/// The number of licenses that will activate on this date
	/// </summary>
	[DataMember(Name = "toActivateCount")]
	public int ToActivateCount { get; set; }

	/// <summary>
	/// The soonest license activation date
	/// </summary>
	[DataMember(Name = "activationDate")]
	public DateTime ActivationDate { get; set; }
}
