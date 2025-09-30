namespace Meraki.Api.Data;

/// <summary>
/// highSpeed settings for the port
/// </summary>
[DataContract]
public class SwitchPortHighSpeed
{
	/// <summary>
	/// For C9500-32QC, whether or not the port is enabled for high speed.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }
}
