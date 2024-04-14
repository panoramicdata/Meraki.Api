namespace Meraki.Api.Data;

/// <summary>
/// Device Cellular Sims SimFailover
/// </summary>
[DataContract]
public class DeviceCellularSimsSimFailover
{
	/// <summary>
	/// Timeout
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "timeout")]
	public int? Timeout { get; set; }

	/// <summary>
	/// Enabled
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }
}
