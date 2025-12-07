namespace Meraki.Api.Data;

/// <summary>
/// API response codes history aggregated by admin
/// </summary>
[DataContract]
public class ApiResponseCodesHistoryByAdmin
{
	/// <summary>
	/// Database ID for the admin user who made an API request
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "adminId")]
	public string? AdminId { get; set; }

	/// <summary>
	/// Admin user's name
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string? Name { get; set; }

	/// <summary>
	/// Admin user's email
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "email")]
	public string? Email { get; set; }

	/// <summary>
	/// Overall response code information
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "overall")]
	public ApiResponseCodeOverall? Overall { get; set; }
}
