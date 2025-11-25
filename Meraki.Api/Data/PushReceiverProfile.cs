namespace Meraki.Api.Data;

/// <summary>
/// Push Receiver Profile
/// </summary>
[DataContract]
public class PushReceiverProfile : NamedItem
{
	/// <summary>
	/// The immutable name (custom identifier)
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "iname")]
	public string? Iname { get; set; }

	/// <summary>
	/// Description of this receiver's purpose
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "description")]
	public string? Description { get; set; }

	/// <summary>
	/// The receiver configuration
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "receiver")]
	public PushReceiver? Receiver { get; set; }
}
