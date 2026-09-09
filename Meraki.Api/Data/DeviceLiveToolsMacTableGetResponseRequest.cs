namespace Meraki.Api.Data;

/// <summary>
/// MAC table request parameters
/// </summary>
[DataContract]
public class DeviceLiveToolsMacTableGetResponseRequest
{
	/// <summary>
	/// Device serial number
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// MAC address used to filter MAC table entries. Must be a colon-delimited six-octet MAC address, for example '00:11:22:a0:b1:c2'. Matching is case-insensitive.
	/// </summary>
	[ApiAccess(ApiAccess.ReadCreate)]
	[DataMember(Name = "mac")]
	public string? Mac { get; set; }
}
