namespace Meraki.Api.Data;

/// <summary>
/// Secure connect settings
/// </summary>
[DataContract]
public class NetworkSettingsSecureConnect
{
	/// <summary>
	/// Enabled?
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }
}
