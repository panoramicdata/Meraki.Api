namespace Meraki.Api.Data;

/// <summary>
/// ApplianceDnsLocalProfile
/// </summary>
[DataContract]
public class ApplianceDnsLocalProfile
{
	/// <summary>
	/// Name of profile
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Profile ID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "profileId")]
	public string ProfileId { get; set; } = string.Empty;
}
