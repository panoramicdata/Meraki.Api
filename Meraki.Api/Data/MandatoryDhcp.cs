namespace Meraki.Api.Data;

/// <summary>
/// Mandatory Dhcp
/// </summary>
[DataContract]
public class MandatoryDhcp
{
	/// <summary>
	/// Whether enabled
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }
}
