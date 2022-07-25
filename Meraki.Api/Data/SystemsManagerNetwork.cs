namespace Meraki.Api.Data;

[DataContract]
public class SystemsManagerNetwork
{
	/// <summary>
	/// The network ID of the Systems Manager network.
	/// </summary>
	[ApiForeignKey(typeof(Network))]
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;
}