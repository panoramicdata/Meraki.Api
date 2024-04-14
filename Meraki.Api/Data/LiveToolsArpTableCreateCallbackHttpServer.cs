namespace Meraki.Api.Data;

/// <summary>
/// Live Tools Arp Table Create Callback HttpServer
/// </summary>
[DataContract]

public class LiveToolsArpTableCreateCallbackHttpServer
{
	/// <summary>
	/// The webhook receiver ID that will receive information. If specifying this, please leave the url and sharedSecret fields blank.l.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string? Id { get; set; }
}
