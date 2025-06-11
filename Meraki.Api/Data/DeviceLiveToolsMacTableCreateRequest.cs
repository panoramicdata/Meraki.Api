namespace Meraki.Api.Data;

/// <summary>
/// Device Live Tools MAC Table Create Request
/// </summary>
[DataContract]
public class DeviceLiveToolsMacTableCreateRequest
{
	/// <summary>
	/// Details for the callback. Please include either an httpServerId OR url and sharedSecret
	/// </summary>
	[DataMember(Name = "callback")]
	public DeviceLiveToolsMacTableCreateRequestCallback? Callback { get; set; }
}
