namespace Meraki.Api.Data;

[DataContract]
public class RegionHost
{
	/// <summary>
	/// Region Host Name - Undocumented 2024-04-18
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;
}