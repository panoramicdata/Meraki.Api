namespace Meraki.Api.Data;

/// <summary>
/// A Switch Port Profile
/// </summary>
[DataContract]
public class SwitchPortsProfile : NamedIdentifiedItem
{
	/// <summary>
	/// Text describing the profile
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[ApiKey]
	[DataMember(Name = "description")]
	public string? Description { get; set; }

	/// <summary>
	/// An immutable name that can be used as an ID for looking up and performing operations on a profile.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "iname")]
	public string? Iname { get; set; }

	/// <summary>
	/// ID of the network the profile belongs to.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "networkId")]
	public string? NetworkId { get; set; }

	/// <summary>
	/// Space-separated list of tags
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "tags")]
	public List<string>? Tags { get; set; }

	/// <summary>
	/// Switch Port Profile Attributes
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "port")]
	public SwitchPortsProfilePort? Port { get; set; }
}
