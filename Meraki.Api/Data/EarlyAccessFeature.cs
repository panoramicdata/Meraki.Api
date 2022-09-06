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
	public string ShortName { get; } = string.Empty;

	/// <summary>
	/// Descriptions
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "descriptions")]
	public EarlyAccessFeatureDescription Descriptions { get; } = new();

	/// <summary>
	/// Topic
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "topic")]
	public string Topic { get; } = string.Empty;

	/// <summary>
	/// Is Organization Scoped Only
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "isOrgScopedOnly")]
	public bool IsOrgScopedOnly { get; }
}