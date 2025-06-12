namespace Meraki.Api.Data;

/// <summary>
/// Noise threshold. 'ambient' must be provided
/// </summary>
[DataContract]
public class OrganizationsSensorAlertProfileConditionThresholdNoise
{
	/// <summary>
	/// Ambient noise threshold. One of 'level' or 'quality' must be provided.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ambient")]
	public OrganizationsSensorAlertProfileConditionThresholdNoiseAmbient Ambient { get; set; } = new();
}
