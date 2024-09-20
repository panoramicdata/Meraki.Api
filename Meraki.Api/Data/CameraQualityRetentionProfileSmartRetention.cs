namespace Meraki.Api.Data;

/// <summary>
/// CreateNetworkCameraQualityRetentionProfileSmartRetention
/// </summary>
[DataContract]
public class CameraQualityRetentionProfileSmartRetention
{
	/// <summary>
	/// Boolean indicating if Smart Retention is enabled(true) or disabled(false).
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }
}
