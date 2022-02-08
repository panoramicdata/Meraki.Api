namespace Meraki.Api.Data;

/// <summary>
/// Appliance settings
/// </summary>
[DataContract]
public class ApplianceSettings
{
	/// <summary>
	/// Client tracking method
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "clientTrackingMethod")]
	public string ClientTrackingMethod { get; set; } = string.Empty;
}
