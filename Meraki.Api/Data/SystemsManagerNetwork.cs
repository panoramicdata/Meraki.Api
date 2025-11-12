namespace Meraki.Api.Data;

/// <summary>
/// Systems Manager Network
/// </summary>
[DataContract]
public class SystemsManagerNetwork
{
	/// <summary>
	/// The network ID of the Systems Manager network.
	/// </summary>
	[ApiForeignKey(typeof(Network))]
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "id")]
	public string? Id { get; set; }

	/// <summary>
	/// Gets the name
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string? Name { get; set; }
}
