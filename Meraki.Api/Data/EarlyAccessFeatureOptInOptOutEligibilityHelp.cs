namespace Meraki.Api.Data;

/// <summary>
/// Additional help information
/// </summary>
[DataContract]
public class EarlyAccessFeatureOptInOptOutEligibilityHelp
{
	/// <summary>
	/// Help link label
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "help")]
	public string Help { get; set; } = string.Empty;

	/// <summary>
	/// Help link url
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "url")]
	public string Url { get; set; } = string.Empty;
}