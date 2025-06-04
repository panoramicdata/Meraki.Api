namespace Meraki.Api.Data;

/// <summary>
/// Network Umbrella Account Enable Protection Response
/// </summary>
[DataContract]
public class NetworkUmbrellaAccountEnableProtectionResponse
{
	/// <summary>
	/// Success message
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "message")]
	public string Message { get; set; } = string.Empty;

	/// <summary>
	/// Success
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "success")]
	public bool Success { get; set; }
}
