namespace Meraki.Api.Data;
/// <summary>
/// Links
/// </summary>
[ApiAccessReadOnlyClass]
[DataContract]
public class LinkLayerLinks
{
	/// <summary>
	/// Ends
	/// </summary>
	[DataMember(Name = "ends")]
	public List<LinkLayerLinksEnds> Ends { get; set; } = new();

	/// <summary>
	/// Last reported at
	/// </summary>
	[DataMember(Name = "lastReportedAt")]
	public string LastReportedAt { get; set; } = string.Empty;
}
