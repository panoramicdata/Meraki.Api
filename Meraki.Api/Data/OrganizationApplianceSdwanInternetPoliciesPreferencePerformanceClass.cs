namespace Meraki.Api.Data;

/// <summary>
/// Performance class setting for uplink preference rule
/// </summary>
[DataContract]
public class OrganizationApplianceSdwanInternetPoliciesPreferencePerformanceClass
{
	/// <summary>
	/// Name of builtin performance class. Must be present when performanceClass type is 'builtin' and value must be one of: 'VoIP'
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "builtinPerformanceClassName")]
	public PerformanceClassName BuiltinPerformanceClassName { get; set; }

	/// <summary>
	/// ID of created custom performance class, must be present when performanceClass type is "custom"
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "customPerformanceClassId")]
	public string CustomPerformanceClassId { get; set; } = string.Empty;

	/// <summary>
	/// Type of this performance class. Must be one of: 'builtin' or 'custom'
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "type")]
	public PerformanceClassType Type { get; set; }
}
