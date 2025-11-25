namespace Meraki.Api.Data;

/// <summary>
/// Push receiver reference for profiles
/// </summary>
[DataContract]
public class PushReceiver
{
	/// <summary>
	/// The receiver ID (webhook HTTP server ID)
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "id")]
	public string? Id { get; set; }

	/// <summary>
	/// The receiver immutable name (iname)
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "iname")]
	public string? Iname { get; set; }
}
