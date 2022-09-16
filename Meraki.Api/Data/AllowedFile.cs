namespace Meraki.Api.Data;

/// <summary>
/// AllowedFile
/// </summary>
[DataContract]
public class AllowedFile
{
	/// <summary>
	/// The file sha256 hash to allow
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "sha256")]
	public string Sha256 { get; set; } = string.Empty;

	/// <summary>
	/// Comment about the allowed entity
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "comment")]
	public string Comment { get; set; } = string.Empty;
}
