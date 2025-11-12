namespace Meraki.Api.Data;

/// <summary>
/// Security Center
/// </summary>
[ApiAccessReadOnlyClass]
[DataContract]
public class SecurityCenter
{
	/// <summary>
	/// Whether rooted
	/// </summary>
	[DataMember(Name = "isRooted")]
	public bool IsRooted { get; set; }

	/// <summary>
	/// Whether it has anti virus
	/// </summary>
	[DataMember(Name = "hasAntiVirus")]
	public bool HasAntiVirus { get; set; }

	/// <summary>
	/// Gets the anti virus name
	/// </summary>
	[DataMember(Name = "antiVirusName")]
	public string AntiVirusName { get; set; } = string.Empty;

	/// <summary>
	/// Whether fire wall enabled
	/// </summary>
	[DataMember(Name = "isFireWallEnabled")]
	public bool IsFireWallEnabled { get; set; }

	/// <summary>
	/// Whether it has fire wall installed
	/// </summary>
	[DataMember(Name = "hasFireWallInstalled")]
	public bool HasFireWallInstalled { get; set; }

	/// <summary>
	/// Gets the fire wall name
	/// </summary>
	[DataMember(Name = "fireWallName")]
	public string FireWallName { get; set; } = string.Empty;

	/// <summary>
	/// Whether disk encrypted
	/// </summary>
	[DataMember(Name = "isDiskEncrypted")]
	public bool IsDiskEncrypted { get; set; }

	/// <summary>
	/// Whether auto login disabled
	/// </summary>
	[DataMember(Name = "isAutoLoginDisabled")]
	public bool IsAutoLoginDisabled { get; set; }

	/// <summary>
	/// Gets the id
	/// </summary>
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Gets the running procs
	/// </summary>
	[DataMember(Name = "runningProcs")]
	public string RunningProcs { get; set; } = string.Empty;
}
