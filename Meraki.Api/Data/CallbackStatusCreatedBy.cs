namespace Meraki.Api.Data;

/// <summary>
/// CallbackStatusCreatedBy
/// </summary>
[DataContract]
public class CallbackStatusCreatedBy
{
	/// <summary>
	/// The ID of the user who initiated the callback
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "adminId")]
	public string AdminId { get; set; } = string.Empty;
}
