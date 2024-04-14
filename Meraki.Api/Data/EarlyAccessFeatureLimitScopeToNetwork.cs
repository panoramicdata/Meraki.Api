namespace Meraki.Api.Data;

/// <summary>
/// Early Access Feature Descriptions
/// </summary>
[DataContract]
public class EarlyAccessFeatureDescription
{
#pragma warning disable CA1720 // Identifier contains type name
	/// <summary>
	/// Short Description
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "short")]
	public string Short { get; set; } = string.Empty;

	/// <summary>
	/// Long Description
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "long")]
	public string Long { get; set; } = string.Empty;
#pragma warning restore CA1720 // Identifier contains type name
}