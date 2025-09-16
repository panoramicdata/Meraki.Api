namespace Meraki.Api.Data;

/// <summary>
/// Undocumented
/// </summary>
[DataContract]
public class WirelessRfProfileBe
{
	/// <summary>
	/// Undocumented
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }
}