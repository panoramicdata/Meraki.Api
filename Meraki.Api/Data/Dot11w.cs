namespace Meraki.Api.Data;

/// <summary>
/// The current setting for Protected Management Frames (802.11w).
/// </summary>
[DataContract]
public class Dot11w
{
	/// <summary>
	/// Enabled
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }

	/// <summary>
	/// Required
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "required")]
	public bool Required { get; set; }
}
