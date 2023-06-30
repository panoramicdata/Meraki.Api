namespace Meraki.Api.Data;

/// <summary>
/// Switch Settings Uplink Client Sampling
/// </summary>
[DataContract]
public class SwitchSettingsUplinkClientSampling
{
	/// <summary>
	/// Enabled
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }
}
