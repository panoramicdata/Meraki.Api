namespace Meraki.Api.Data;

/// <summary>
/// PPPOE
/// </summary>
[ApiAccessReadOnlyClass]
[DataContract]

public class StackDeviceUplinksPppoe
{
	/// <summary>
	/// Enabled
	/// </summary>
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }
}
