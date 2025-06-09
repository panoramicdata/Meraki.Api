namespace Meraki.Api.Data;

/// <summary>
/// Nameservers of the cluster
/// </summary>
[DataContract]
public class OrganizationCampusGatewayDevicesUplinksLocalOverridesByDeviceResponseItemNameservers
{
	/// <summary>
	/// Addresses of the nameservers
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "addresses")]
	public List<string> Addresses { get; set; } = [];
}