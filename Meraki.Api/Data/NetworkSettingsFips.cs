namespace Meraki.Api.Data;

/// <summary>
/// FIPS - undocumented
/// </summary>
[DataContract]
public class NetworkSettingsFips
{
	/// <summary>
	/// Enabled
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }
}
