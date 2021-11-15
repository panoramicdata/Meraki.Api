namespace Meraki.Api.Data;

/// <summary>
/// VPP account information
/// </summary>
[DataContract]
public class SmVppAccount
{
	/// <summary>
	/// Id
	/// </summary>
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// VPP service token
	/// </summary>
	[DataMember(Name = "vppServiceToken")]
	public string VppServiceToken { get; set; } = string.Empty;
}
