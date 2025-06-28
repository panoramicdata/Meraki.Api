namespace Meraki.Api.Data;

/// <summary>
/// Client IP Address Detail
/// </summary>
[DataContract]
public class OrganizationsNacSessionDetailsClientAddress
{
	/// <summary>
	/// Client IP Address
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "address")]
	public string Address { get; set; } = string.Empty;

	/// <summary>
	/// Client IP Address Type
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "protocol")]
	public string Protocol { get; set; } = string.Empty;
}