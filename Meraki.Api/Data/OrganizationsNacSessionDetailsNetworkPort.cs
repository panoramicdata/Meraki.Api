namespace Meraki.Api.Data;

/// <summary>
/// Network Port Details
/// </summary>
[DataContract]
public class OrganizationsNacSessionDetailsNetworkPort
{
	/// <summary>
	/// Network Port Name
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;
}