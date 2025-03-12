namespace Meraki.Api.Data;

/// <summary>
/// Uplinks Roaming
/// </summary>
[DataContract]
public class UplinksRoaming
{
	/// <summary>
	/// Status
	/// </summary>
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;
}
