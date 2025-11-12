namespace Meraki.Api.Data;

/// <summary>
/// Fixed Ip Assignment
/// </summary>
[DataContract]
public class FixedIpAssignment : NamedItem
{
	/// <summary>
	/// The IP address you want to assign to a specific server or device
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "ip")]
	public string Ip { get; set; } = string.Empty;

	/// <summary>
	/// A descriptive name of the assignment
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public new string Name { get; set; } = string.Empty;

	/// <summary>
	/// The MAC address of the server or device that hosts the internal resource that you wish to receive the specified IP address
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "mac")]
	public string Mac { get; set; } = string.Empty;
}
