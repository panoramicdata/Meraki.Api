using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// Info
/// </summary>
[DataContract]
public class OpenApiInfo
{
	/// <summary>
	/// Version
	/// </summary>
	[DataMember(Name = "version")]
	public string Version { get; set; } = string.Empty;

	/// <summary>
	/// Title
	/// </summary>
	[DataMember(Name = "title")]
	public string Title { get; set; } = string.Empty;

	/// <summary>
	/// Description
	/// </summary>
	[DataMember(Name = "description")]
	public string Description { get; set; } = string.Empty;
}
