namespace Meraki.Api.Data;

/// <summary>
/// HTTP servers
/// </summary>
[DataContract]
public class WebHookHttpServerPayloadTemplate
{
	/// <summary>
	/// Id
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Name
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;
}