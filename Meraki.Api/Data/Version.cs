namespace Meraki.Api.Data;

/// <summary>
/// Current version
/// </summary>
[DataContract]
public class Version
{
	/// <summary>
	/// Id
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public int Id { get; set; }

	/// <summary>
	/// Firmware
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "firmware")]
	public string Firmware { get; set; } = string.Empty;

	/// <summary>
	/// Short name
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "shortName")]
	public string ShortName { get; set; } = string.Empty;

	/// <summary>
	/// Release type
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "releaseType")]
	public string ReleaseType { get; set; } = string.Empty;

	/// <summary>
	/// Release date
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "releaseDate")]
	public DateTime ReleaseDate { get; set; }
}
