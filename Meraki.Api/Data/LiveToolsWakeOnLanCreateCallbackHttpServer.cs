namespace Meraki.Api.Data;

/// <summary>
/// Wake On Lan Create Callback Http Server
/// </summary>
[DataContract]

public class LiveToolsWakeOnLanCreateCallbackHttpServer
{
	/// <summary>
	/// The webhook receiver ID that will receive information. If specifying this, please leave the url and sharedSecret fields blank.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;
}
