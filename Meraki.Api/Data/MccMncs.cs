namespace Meraki.Api.Data;

/// <summary>
/// Mcc Mncs
/// </summary>
[DataContract]
public class MccMncs
{
	/// <summary>
	/// Mcc
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "mcc")]
	public string Mcc { get; set; } = string.Empty;

	/// <summary>
	/// Mnc
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "mnc")]
	public string Mnc { get; set; } = string.Empty;
}
