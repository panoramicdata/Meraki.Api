namespace Meraki.Api.Data;

/// <summary>
/// Splash Settings Self Registration
/// </summary>
[DataContract]
public class SelfRegistration
{
	/// <summary>
	/// Enabled
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }

	/// <summary>
	/// Authorization Type
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "authorizationType")]
	public string? AuthorizationType { get; set; }
}