namespace Meraki.Api.Data;

/// <summary>
/// Live Tools Arp Table
/// </summary>
[DataContract]

public class LiveToolsArpTable
{
	/// <summary>
	/// Id of the ARP table request. Used to check the status of the request.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "arpTableId")]
	public string ArpTableId { get; set; } = string.Empty;

	/// <summary>
	/// Status of the ARP table request.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	/// <summary>
	/// GET this url to check the status of your ARP table request.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "url")]
	public string Url { get; set; } = string.Empty;

	/// <summary>
	/// Information for callback used to send back results
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "callback")]
	public LiveToolsArpTableCallback Callback { get; set; } = new();

	/// <summary>
	/// ARP table request parameters
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "request")]
	public LiveToolsArpTableRequest Request { get; set; } = new();
}
