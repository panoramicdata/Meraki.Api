namespace Meraki.Api.Data;

/// <summary>
/// A reserved IP range
/// </summary>
[DataContract]
public class ReservedIpRange
{
	/// <summary>
	/// Start IP
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "start")]
	public string Start { get; set; } = string.Empty;

	/// <summary>
	/// End IP
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "end")]
	public string End { get; set; } = string.Empty;

	/// <summary>
	/// Comment
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "comment")]
	public string Comment { get; set; } = string.Empty;
}
