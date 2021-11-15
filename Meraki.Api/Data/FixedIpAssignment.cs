namespace Meraki.Api.Data;

[DataContract]
public class FixedIpAssignment : NamedItem
{
	/// <summary>
	/// IP Address
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "ip")]
	public string Ip { get; set; } = string.Empty;

	/// <summary>
	/// Name
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public new string Name { get; set; } = string.Empty;

	/// <summary>
	/// MAC
	/// </summary>
	[DataMember(Name = "mac")]
	public string? Mac { get; set; } = string.Empty;
}
