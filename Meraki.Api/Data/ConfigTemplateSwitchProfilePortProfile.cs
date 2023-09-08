namespace Meraki.Api.Data;

/// <summary>
/// Profile Attributes
/// </summary>
[DataContract]
public class ConfigTemplateSwitchProfilePortProfile
{
	/// <summary>
	/// When enabled, the ID of the port profile used to override the port's configuration.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "id")]
	public string? Id { get; set; }

	/// <summary>
	/// When enabled, the IName of the profile.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "iname")]
	public string? Iname { get; set; }

	/// <summary>
	/// When enabled, override this port's configuration with a port profile.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }
}
