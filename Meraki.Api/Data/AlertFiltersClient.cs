namespace Meraki.Api.Data;

[DataContract]
public class AlertFiltersClient
{
	/// <summary>
	/// Client mac address
	/// </summary>
	[DataMember(Name = "mac")]
	public string? Mac { get; set; }

	/// <summary>
	/// Client name
	/// </summary>
	[DataMember(Name = "name")]
	public string? Name { get; set; }
}