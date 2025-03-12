namespace Meraki.Api.Data;

/// <summary>
/// ApplianceDnsLocalProfileCreateUpdateRequest
/// </summary>
[DataContract]
public class ApplianceDnsLocalProfileCreateUpdateRequest
{
	/// <summary>
	/// Name of profile
	/// </summary>
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;
}
