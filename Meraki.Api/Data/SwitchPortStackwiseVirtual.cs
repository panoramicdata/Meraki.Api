namespace Meraki.Api.Data;

/// <summary>
/// Stackwise Virtual settings for the switch port
/// </summary>
[DataContract]
public class SwitchPortStackwiseVirtual
{
	/// <summary>
	/// For SVL devices, whether or not the port is used for Dual Active Detection.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "isDualActiveDetector")]
	public bool IsDualActiveDetector { get; set; }

	/// <summary>
	/// For SVL devices, whether or not the port is used for StackWise Virtual Link.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "isStackWiseVirtualLink")]
	public bool IsStackWiseVirtualLink { get; set; }
}
