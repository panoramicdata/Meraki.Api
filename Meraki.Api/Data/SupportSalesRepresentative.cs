namespace Meraki.Api.Data;

/// <summary>
/// Support Sales Representative
/// </summary>
[DataContract]
public class SupportSalesRepresentative
{
	/// <summary>
	/// Email
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "email")]
	public string Email { get; set; } = string.Empty;

	/// <summary>
	/// Name
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Phone Number
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "phone")]
	public string Phone { get; set; } = string.Empty;
}
