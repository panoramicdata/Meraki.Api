namespace Meraki.Api.Data;

/// <summary>
/// Secure port settings - Formerly secure connect
/// </summary>
[DataContract]
public class NetworkSettingsSecurePort
{
	/// <summary>
	/// Enabled?
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }
}
