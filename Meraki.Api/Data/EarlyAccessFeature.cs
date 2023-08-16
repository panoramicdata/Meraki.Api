namespace Meraki.Api.Data;

/// <summary>
/// Early Access Feature
/// </summary>
[DataContract]
public class EarlyAccessFeature : NamedItem
{
	/// <summary>
	/// Short Name
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "shortName")]
	public string ShortName { get; set; } = string.Empty;

	/// <summary>
	/// Descriptions
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "descriptions")]
	public EarlyAccessFeatureDescription Descriptions { get; set; } = new();

	/// <summary>
	/// Topic
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "topic")]
	public string Topic { get; set; } = string.Empty;

	/// <summary>
	/// Is Organization Scoped Only
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "isOrgScopedOnly")]
	public bool IsOrgScopedOnly { get; set; }

	/// <summary>
	/// Documentation Link
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "documentationLink")]
	public string DocumentationLink { get; set; } = string.Empty;

	/// <summary>
	/// Support Link
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "supportLink")]
	public string SupportLink { get; set; } = string.Empty;
}