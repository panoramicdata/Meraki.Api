namespace Meraki.Api.Data;

/// <summary>
/// The webhook receiver used for the callback webhook.
/// </summary>
[DataContract]

public class LiveToolsPingCallbackHttpServer
{
	/// <summary>
	/// The webhook receiver ID that will receive information. If specifying this, please leave the url and sharedSecret fields blank.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string? Id { get; set; } = string.Empty;
}
