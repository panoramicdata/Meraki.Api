namespace Meraki.Api.Data;

/// <summary>
/// Early Access Feature Descriptions
/// </summary>
[DataContract]
public class EarlyAccessFeatureDescription
{
	/// <summary>
	/// Short Description
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "short")]
	public string ShortDescription { get; set; } = string.Empty;

	/// <summary>
	/// Long Description
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "long")]
	public string LongDescription { get; set; } = string.Empty;
}