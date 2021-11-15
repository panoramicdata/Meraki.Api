namespace Meraki.Api.Data;

/// <summary>
/// Firmware upgrade rollback
/// </summary>
[DataContract]
public class FirmwareUpgradeRollbackRequest
{
	/// <summary>
	/// Product type to rollback (if the network is a combined network)
	/// </summary>
	[DataMember(Name = "product")]
	public string Product { get; set; } = string.Empty;

	/// <summary>
	/// Scheduled time for the rollback
	/// </summary>
	[DataMember(Name = "time")]
	public string Time { get; set; } = string.Empty;

	/// <summary>
	/// Version to downgrade to (if the network has firmware flexibility)
	/// </summary>
	[DataMember(Name = "toVersion")]
	public ToVersion ToVersion { get; set; } = new();

	/// <summary>
	/// Reasons for the rollback
	/// </summary>
	[DataMember(Name = "reasons")]
	public List<Reasons> Reasons { get; set; } = new();
}
