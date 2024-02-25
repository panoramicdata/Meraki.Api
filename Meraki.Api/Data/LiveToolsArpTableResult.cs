namespace Meraki.Api.Data;

/// <summary>
/// Live Tools Arp Table Result
/// </summary>
[DataContract]

public class LiveToolsArpTableResult
{
	/// <summary>
	/// Id of the ARP table request. Used to check the status of the request.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "arpTableId")]
	public string ArpTableId { get; set; } = string.Empty;

	/// <summary>
	/// An error message for a failed execution
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "error")]
	public string Error { get; set; } = string.Empty;

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
	/// ARP table request parameters
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "request")]
	public LiveToolsArpTableResultRequest Request { get; set; } = new();

	/// <summary>
	/// The ARP table entries
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "entries")]
	public List<LiveToolsArpTableResultTableEntry> Entries { get; set; } = new();
}
