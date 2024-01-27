namespace Meraki.Api.Data;

/// <summary>
/// CreateOrganizationActionBatchCallbackHttpServer
/// </summary>
[DataContract]
public class ActionBatchCreationRequestCallbackHttpServer
{
	/// <summary>
	/// The webhook receiver ID that will receive information. If specifying this, please leave the url and sharedSecret fields blank.
	/// </summary>
	[DataMember(Name = "id")]
	public string? Id { get; set; }
}
