namespace Meraki.Api.Data;

/// <summary>
/// Push Profile (subscription to a topic)
/// </summary>
[DataContract]
public class PushProfile : NamedItem
{
	/// <summary>
	/// The immutable name (custom identifier)
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "iname")]
	public string? Iname { get; set; }

	/// <summary>
	/// Description of this profile's purpose
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "description")]
	public string? Description { get; set; }

	/// <summary>
	/// The topic to subscribe to
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "topic")]
	public PushTopicReference? Topic { get; set; }

	/// <summary>
	/// The receiver to send notifications to
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "receiver")]
	public PushReceiver? Receiver { get; set; }
}
