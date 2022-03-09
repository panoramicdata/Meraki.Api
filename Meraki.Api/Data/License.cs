namespace Meraki.Api.Data;

/// <summary>
/// License
/// </summary>
[DataContract]
public class License
{
	/// <summary>
	/// The key of the license
	/// </summary>
	/// <value>The key of the license</value>
	[DataMember(Name = "key")]
	public string? Key { get; set; }

	/// <summary>
	/// Gets or Sets Mode
	/// </summary>
	[DataMember(Name = "mode")]
	public LicenseMode? Mode { get; set; }
}
