namespace Meraki.Api.Data;

/// <summary>
/// Application Object
/// </summary>
[DataContract]
public class OrganizationApplianceSdwanInternetPoliciesPreferenceTrafficFilterValueDestinationApplication
{
	/// <summary>
	/// Id of the major application, or a list of NBAR Application Category or Application selections
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Name of the major application or application category selected
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// app type (major or nbar)
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;
}