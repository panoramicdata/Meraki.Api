namespace Meraki.Api.Data;

/// <summary>
/// Region Host
/// </summary>
[ApiAccessReadOnlyClass]
[DataContract]
public class RegionHost
{
	/// <summary>
	/// Region Host Name - Undocumented 2024-04-18
	/// </summary>
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;
}
