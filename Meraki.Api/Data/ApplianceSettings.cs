namespace Meraki.Api.Data;

/// <summary>
/// Appliance settings
/// </summary>
[DataContract]
public class ApplianceSettings
{
	/// <summary>
	/// Client tracking method of a network
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "clientTrackingMethod")]
	public string? ClientTrackingMethod { get; set; }

	/// <summary>
	/// Deployment mode of a network
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "deploymentMode")]
	public string? DeploymentMode { get; set; }
}
