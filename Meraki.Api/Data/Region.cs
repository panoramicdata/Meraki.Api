namespace Meraki.Api.Data;

[DataContract]
public class Region : NamedItem
{
	/// <summary>
	/// Host - Undocumented 2024-04-18
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "host")]
	public RegionHost Host { get; set; } = new();
}