using System;
using System.Collections.Generic;
using System.Text;

namespace Meraki.Api.Data;

[DataContract]

public class ClientSearchResult
{
	/// <summary>
	/// Client Id
	/// </summary>
	[DataMember(Name = "clientId")]
	public string ClientId { get; set; } = string.Empty;

	/// <summary>
	/// Mac
	/// </summary>
	[DataMember(Name = "mac")]
	public string Mac { get; set; } = string.Empty;

	/// <summary>
	/// Manufacturer
	/// </summary>
	[DataMember(Name = "manufacturer")]
	public string Manufacturer { get; set; } = string.Empty;

	/// <summary>
	/// Records
	/// </summary>
	[DataMember(Name = "records")]
	public List<ClientSearchResultRecords> Network { get; set; } = new();
}
