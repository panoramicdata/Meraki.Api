namespace Meraki.Api.Data;

/// <summary>
/// Ip Restrictions For Keys
/// </summary>
[DataContract]
public class IpRestrictionsForKeys
{
	/// <summary>
	/// Whether enabled
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }

	/// <summary>
	/// Gets the ranges
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "ranges")]
	public List<string> Ranges { get; set; } = [];
}
