namespace Meraki.Api.Data;

/// <summary>
/// A reserved IP range
/// </summary>
[DataContract]
public class ReservedIpRange
{
	/// <summary>
	/// Starting IP included in the reserved range of IPs
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "start")]
	public string Start { get; set; } = string.Empty;

	/// <summary>
	/// Ending IP included in the reserved range of IPs
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "end")]
	public string End { get; set; } = string.Empty;

	/// <summary>
	/// Comment explaining the reserved IP range
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "comment")]
	public string Comment { get; set; } = string.Empty;
}
