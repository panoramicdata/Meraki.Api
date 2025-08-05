namespace Meraki.Api.Data;

/// <summary>
/// A Recent Swap Request and their Status
/// </summary>
[DataContract]
public class OrganizationInventorySwapResponseSwap
{
	/// <summary>
	/// An action to perform on the devices.old object after swap is complete. enum = ["release from organization inventory", "remove from network"]
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "afterAction")]
	public string AfterAction { get; set; } = string.Empty;

	/// <summary>
	/// An iso8601 timestamp for when the swap completed or failed.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "completedAt")]
	public string CompletedAt { get; set; } = string.Empty;

	/// <summary>
	/// An iso8601 timestamp for the creation of the swap request.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "createdAt")]
	public string CreatedAt { get; set; } = string.Empty;

	/// <summary>
	/// Swap Request ID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// The current status of the swap job. 
	/// </summary>
	[DataMember(Name = "status")]
	public SwapStatus Status { get; set; }

	/// <summary>
	/// A list of error messages for why a swap failed.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "errors")]
	public List<string> Errors { get; set; } = [];

	/// <summary>
	/// The devices involved in the swap
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "devices")]
	public OrganizationInventorySwapResponseSwapDevices Devices { get; set; } = new();
}
