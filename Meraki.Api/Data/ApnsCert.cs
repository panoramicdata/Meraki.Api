namespace Meraki.Api.Data;

/// <summary>
/// APNS certificate
/// </summary>
[ApiAccessReadOnlyClass]
[DataContract]
public class ApnsCert
{
	/// <summary>
	/// Certificate
	/// </summary>
	[DataMember(Name = "certificate")]
	public string Certificate { get; set; } = string.Empty;
}
