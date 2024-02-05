namespace Meraki.Api.Data;

/// <summary>
/// Destination MajorApp
/// </summary>
[DataContract]
public class ValueDestinationMajorApp
{
	/// <summary>
	/// Id - Undocumented
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "id")]
	public string? Id { get; set; }

	/// <summary>
	/// Name - Undocumented
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "name")]
	public string? Name { get; set; }

}
