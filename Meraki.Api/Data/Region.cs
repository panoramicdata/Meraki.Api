namespace Meraki.Api.Data;

/// <summary>
/// Region
/// </summary>
[ApiAccessReadOnlyClass]
[DataContract]
public class Region : NamedItem
{
	/// <summary>
	/// Host - Undocumented 2024-04-18
	/// </summary>
	[DataMember(Name = "host")]
	public RegionHost Host { get; set; } = new();
}
