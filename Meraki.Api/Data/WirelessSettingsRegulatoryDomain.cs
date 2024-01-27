namespace Meraki.Api.Data;

/// <summary>
/// Wireless settings Regulatory Domain
/// </summary>
[DataContract]
public class WirelessSettingsRegulatoryDomain
{
	/// <summary>
	/// Name
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// permits6e
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "permits6e")]
	public bool Permits6e { get; set; }
}
