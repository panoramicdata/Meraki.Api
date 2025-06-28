namespace Meraki.Api.Data;

/// <summary>
/// Additional options for the import
/// </summary>
[DataContract]
public class OrganizationInventoryOnboardingCloudMonitoringPrepareCreateRequestOptions
{
	/// <summary>
	/// Flag to skip adding the device to RDM 
	/// </summary>
	[DataMember(Name = "skipCommit")]
	public bool? SkipCommit { get; set; }
}