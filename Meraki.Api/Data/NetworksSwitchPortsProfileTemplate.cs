namespace Meraki.Api.Data;

/// <summary>
/// Template details
/// </summary>
[DataContract]
public class NetworksSwitchPortsProfileTemplate
{
	/// <summary>
	/// The ID of the node profile associated to switchport
	/// </summary>
	[DataMember(Name = "id")]
	[ApiAccess(ApiAccess.ReadCreate)]
	public int? Id { get; set; }
}
