namespace Meraki.Api.Data;

/// <summary>
/// Validator for push API
/// </summary>
[DataContract]
public class LocationScanningApiValidator
{
	/// <summary>
	/// Validator for push API
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "string")]
	public string ValidatorString { get; set; } = string.Empty;
}