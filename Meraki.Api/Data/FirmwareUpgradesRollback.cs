using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// Rollback
/// </summary>
[DataContract]
public class FirmwareUpgradesRollback
{
	/// <summary>
	/// Product
	/// </summary>
	[DataMember(Name = "product")]
	public string Product { get; set; } = string.Empty;

	/// <summary>
	/// Status
	/// </summary>
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	/// <summary>
	/// Upgrade batch id
	/// </summary>
	[DataMember(Name = "upgradeBatchId")]
	public int UpgradeBatchId { get; set; }

	/// <summary>
	/// Time
	/// </summary>
	[DataMember(Name = "time")]
	public string Time { get; set; } = string.Empty;

	/// <summary>
	/// To version
	/// </summary>
	[DataMember(Name = "toVersion")]
	public ToVersion ToVersion { get; set; } = new();

	/// <summary>
	/// Reasons
	/// </summary>
	[DataMember(Name = "reasons")]
	public List<Reasons> Reasons { get; set; } = new();
}
