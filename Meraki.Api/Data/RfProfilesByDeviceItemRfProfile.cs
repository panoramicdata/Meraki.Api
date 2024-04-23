namespace Meraki.Api.Data;

/// <summary>
/// Rf Profiles By Device Item RF Profile
/// </summary>
[ApiAccessReadOnlyClass]
[DataContract]
public class RfProfilesByDeviceItemRfProfile
{
	/// <summary>
	/// The ID of the RF Profile the device belongs to.
	/// </summary>
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// The name of the RF Profile the device belongs to.
	/// </summary>
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Status to show if this profile is default indoor profile.
	/// </summary>
	[DataMember(Name = "isIndoorDefault")]
	public bool IsIndoorDefault { get; set; }

	/// <summary>
	/// Status to show if this profile is default outdoor profile.
	/// </summary>
	[DataMember(Name = "isOutdoorDefault")]
	public bool IsOutdoorDefault { get; set; }
}
