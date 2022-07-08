namespace Meraki.Api.Data;

/// <summary>
/// Appliance settings
/// </summary>
[DataContract]
public class ApplianceSettings
{
	/// <summary>
	/// Client tracking method
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "clientTrackingMethod")]
	public string? ClientTrackingMethod { get; set; }

	/// <summary>
	/// Deployment Mode
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "deploymentMode")]
	public string? DeploymentMode { get; set; }
}
