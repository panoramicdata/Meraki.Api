namespace Meraki.Api.Data;

/// <summary>
/// Security Group Tag settings for the VLAN
/// </summary>
[DataContract]
public class VlanSgt
{
	/// <summary>
	/// The Security Group Tag ID
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "id")]
	public int? Id { get; set; }
}
