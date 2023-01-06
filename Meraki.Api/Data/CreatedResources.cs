namespace Meraki.Api.Data;

/// <summary>
/// Created resources
/// </summary>
[ApiAccessReadOnlyClass]
[DataContract]
public class CreatedResources
{
	/// <summary>
	/// Id
	/// </summary>
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Uri
	/// </summary>
	[DataMember(Name = "uri")]
	public string Uri { get; set; } = string.Empty;
}
