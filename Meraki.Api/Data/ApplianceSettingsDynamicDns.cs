namespace Meraki.Api.Data;

/// <summary>
/// Appliance Dynamic DNS Settings
/// </summary>
[DataContract]
public class ApplianceSettingsDynamicDns
{
	/// <summary>
	/// Dynamic DNS url prefix. DDNS must be enabled to update
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "prefix")]
	public string? Prefix { get; set; }

	/// <summary>
	/// Dynamic DNS enabled
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }

	/// <summary>
	/// Dynamic DNS url. DDNS must be enabled to update
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "url")]
	public string? Url { get; set; }
}
