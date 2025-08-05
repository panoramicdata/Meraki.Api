namespace Meraki.Api.Data;

/// <summary>
/// Default thresholds for each application
/// </summary>
[DataContract]
public class OrganizationInsightWebAppThresholds
{
	/// <summary>
	/// App goodput
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "goodput")]
	public string Goodput { get; set; } = string.Empty;

	/// <summary>
	/// App response delay
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "responseDelay")]
	public string ResponseDelay { get; set; } = string.Empty;
}