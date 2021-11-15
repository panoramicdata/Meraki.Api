namespace Meraki.Api.Data;

/// <summary>
/// Pii SM key response
/// </summary>
[DataContract]
public class PiiSmKey
{
	/// <summary>
	/// N_1234
	/// </summary>
	[DataMember(Name = "N_1234")]
	public List<string> N1234 { get; set; } = new();
}
