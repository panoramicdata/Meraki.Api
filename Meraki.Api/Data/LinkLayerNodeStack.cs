using System;
using System.Collections.Generic;
using System.Text;

namespace Meraki.Api.Data;
/// <summary>
/// Stack
/// </summary>
[DataContract]

public class LinkLayerNodeStack
{
	/// <summary>
	/// Id
	/// </summary>
	[DataMember(Name = "id")]
	public int Id { get; set; } = 0;

	/// <summary>
	/// Name
	/// </summary>
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Members
	/// </summary>
	[DataMember(Name = "members")]
	public List<LinkLayerNodeStackMember> Type { get; set; } = new();

	/// <summary>
	/// Clients
	/// </summary>
	[DataMember(Name = "clients")]
	public StackDeviceClients Clients { get; set; } = new();
}
