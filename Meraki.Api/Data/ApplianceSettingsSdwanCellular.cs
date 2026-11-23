namespace Meraki.Api.Data;

/// <summary>
/// SD-WAN cellular settings for the appliance - Undocumented, observed in live API responses only
/// </summary>
[DataContract]
public class ApplianceSettingsSdwanCellular
{
	/// <summary>
	/// Whether SD-WAN over cellular is enabled. Can be null
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }
}
