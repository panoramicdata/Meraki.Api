namespace Meraki.Api.Data;

/// <summary>
/// VTY Related Parameters
/// </summary>
[DataContract]
public class OrganizationInventoryOnboardingCloudMonitoringPrepareCreateRequestDeviceVty
{
	/// <summary>
	/// Ending line VTY number
	/// </summary>
	[DataMember(Name = "endLineNumber")]
	public int? EndLineNumber { get; set; }

	/// <summary>
	/// SSH rotary number
	/// </summary>
	[DataMember(Name = "rotaryNumber")]
	public int? RotaryNumber { get; set; }

	/// <summary>
	/// Starting line VTY number
	/// </summary>
	[DataMember(Name = "startLineNumber")]
	public int? StartLineNumber { get; set; }

	/// <summary>
	/// AccessList details
	/// </summary>
	[DataMember(Name = "accessList")]
	public OrganizationInventoryOnboardingCloudMonitoringPrepareCreateRequestDeviceVtyAccessList? AccessList { get; set; }

	/// <summary>
	/// VTY AAA authentication
	/// </summary>
	[DataMember(Name = "authentication")]
	public OrganizationInventoryOnboardingCloudMonitoringPrepareCreateRequestDeviceVtyAuthentication? Authentication { get; set; }

	/// <summary>
	/// VTY AAA authorization
	/// </summary>
	[DataMember(Name = "authorization")]
	public OrganizationInventoryOnboardingCloudMonitoringPrepareCreateRequestDeviceVtyAuthorization? Authorization { get; set; }
}
