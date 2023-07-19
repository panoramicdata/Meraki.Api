namespace Meraki.Api.Data;

/// <summary>
/// The current setting for Protected Management Frames (802.11w).
/// </summary>
[DataContract]
public class NetworkApplianceSsidDot11w
{
	/// <summary>
	/// Whether 802.11w is enabled or not.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }

	/// <summary>
	/// (Optional) Whether 802.11w is required or not.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "required")]
	public bool? Required { get; set; }
}
