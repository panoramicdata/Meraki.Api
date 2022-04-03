namespace Meraki.Api.Data;

/// <summary>
/// Response
/// </summary>
[ApiAccessReadOnlyClass]
[DataContract]
public class ActionResponse
{
	/// <summary>
	/// Success
	/// </summary>
	[DataMember(Name = "success")]
	public bool Success { get; set; }
}
