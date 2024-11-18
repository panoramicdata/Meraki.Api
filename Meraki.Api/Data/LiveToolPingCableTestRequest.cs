namespace Meraki.Api.Data;

/// <summary>
/// Live Tools Cable Test Request
/// </summary>
[DataContract]

public class LiveToolsCableTestRequest
{
	/// <summary>
	/// Device serial number
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// A list of ports for which to perform the cable test.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ports")]
	public List<string> Ports { get; set; } = [];
}
