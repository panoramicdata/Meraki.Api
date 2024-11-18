namespace Meraki.Api.Data;

/// <summary>
/// Destination Application
/// </summary>
[DataContract]
public class ValueDestinationApplication
{
	/// <summary>
	/// Id of the major application, or a list of NBAR Application Category or Application selections
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "id")]
	public string? Id { get; set; }

	/// <summary>
	/// Name of the major application or application category selected
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "name")]
	public string? Name { get; set; }

	/// <summary>
	/// app type (major or nbar)
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "type")]
	public string? Type { get; set; }
}
