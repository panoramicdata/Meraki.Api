namespace Meraki.Api.Data;

[DataContract]
public class AlertFiltersClient
{
	/// <summary>
	/// Client mac address
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "mac")]
	public string? Mac { get; set; }

	/// <summary>
	/// Client name
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "name")]
	public string? Name { get; set; }
}