namespace Meraki.Api.Data;

/// <summary>
/// Represents a list of WLANs with their creation date, identifier, and XML data.
/// </summary>
[ApiAccessReadOnlyClass]
[DataContract]
public class WlanList
{
	[DataMember(Name = "createdAt")]
	public DateTime CreatedAt { get; set; }

	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	[DataMember(Name = "xml")]
	public string Xml { get; set; } = string.Empty;
}
