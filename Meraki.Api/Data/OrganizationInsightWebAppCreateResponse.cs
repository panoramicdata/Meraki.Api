namespace Meraki.Api.Data;

/// <summary>
/// Organization Insight Web Application Create Response
/// </summary>
[DataContract]
public class OrganizationInsightWebAppCreateResponse
{
	/// <summary>
	/// Category type for web application
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "category")]
	public string Category { get; set; } = string.Empty;

	/// <summary>
	/// Counter set rule id
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counterSetRuleId")]
	public string CounterSetRuleId { get; set; } = string.Empty;

	/// <summary>
	/// Http hostname for tracking web app
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "expression")]
	public string Expression { get; set; } = string.Empty;

	/// <summary>
	/// Web Application name
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// If custom host or port is specified, this field populates
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "signature")]
	public OrganizationInsightWebAppCreateResponseSignature Signature { get; set; } = new();

	/// <summary>
	/// Default thresholds for each application
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "thresholds")]
	public OrganizationInsightWebAppThresholds Thresholds { get; set; } = new();
}
