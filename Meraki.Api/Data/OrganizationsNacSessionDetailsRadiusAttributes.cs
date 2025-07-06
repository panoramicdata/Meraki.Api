namespace Meraki.Api.Data;

/// <summary>
/// Attributes
/// </summary>
[DataContract]
public class OrganizationsNacSessionDetailsRadiusAttributes
{
	/// <summary>
	/// Incoming RADIUS Attributes
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "incoming")]
	public List<OrganizationsNacSessionDetailsRadiusAttributesInformation> Incoming { get; set; } = [];

	/// <summary>
	/// Outgoing RADIUS Attributes
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "outgoing")]
	public List<OrganizationsNacSessionDetailsRadiusAttributesInformation> Outgoing { get; set; } = [];
}
