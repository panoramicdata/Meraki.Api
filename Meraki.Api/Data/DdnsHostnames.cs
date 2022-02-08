namespace Meraki.Api.Data;

/// <summary>
/// Dynamic DNS hostnames
/// </summary>
[DataContract]
public class DdnsHostnames
{
	/// <summary>
	/// activeDdnsHostname
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "activeDdnsHostname")]
	public string? ActiveDdnsHostname { get; set; }

	/// <summary>
	/// ddnsHostnameWan1
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ddnsHostnameWan1")]
	public string? DdnsHostnameWan1 { get; set; }

	/// <summary>
	/// ddnsHostnameWan2
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ddnsHostnameWan2")]
	public string? DdnsHostnameWan2 { get; set; }
}
