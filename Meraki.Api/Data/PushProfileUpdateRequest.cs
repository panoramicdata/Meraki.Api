namespace Meraki.Api.Data;

/// <summary>
/// Request model for updating a Push Profile
/// </summary>
[DataContract]
public class PushProfileUpdateRequest
{
	/// <summary>
	/// Updated description of this profile's purpose
	/// </summary>
	[ApiAccess(ApiAccess.Update)]
	[DataMember(Name = "description")]
	public string? Description { get; set; }
}
