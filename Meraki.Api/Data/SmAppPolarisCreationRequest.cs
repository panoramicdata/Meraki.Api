namespace Meraki.Api.Data;

/// <summary>
/// CreateNetworkSmAppPolaris
/// </summary>
[DataContract]
public class SmAppPolarisCreationRequest
{
	/// <summary>
	/// The scope (one of all, none, automatic, withAny, withAll, withoutAny, or withoutAll) and a set of tags of the devices to be assigned
	/// </summary>
	/// <value>The scope (one of all, none, automatic, withAny, withAll, withoutAny, or withoutAll) and a set of tags of the devices to be assigned</value>
	[DataMember(Name = "scope")]
	public string Scope { get; set; } = null!;

	/// <summary>
	/// The manifest URL of the Polaris app (one of manifestUrl and bundleId must be provided)
	/// </summary>
	/// <value>The manifest URL of the Polaris app (one of manifestUrl and bundleId must be provided)</value>
	[DataMember(Name = "manifestUrl")]
	public string ManifestUrl { get; set; } = null!;

	/// <summary>
	/// The bundleId of the Polaris app (one of manifestUrl and bundleId must be provided)
	/// </summary>
	/// <value>The bundleId of the Polaris app (one of manifestUrl and bundleId must be provided)</value>
	[DataMember(Name = "bundleId")]
	public string BundleId { get; set; } = null!;

	/// <summary>
	/// (optional) Whether or not SM should auto-install this app (one of true or false). False by default.
	/// </summary>
	/// <value>(optional) Whether or not SM should auto-install this app (one of true or false). False by default.</value>
	[DataMember(Name = "preventAutoInstall")]
	public bool? PreventAutoInstall { get; set; }

	/// <summary>
	/// (optional) Whether or not the app should use VPP by device assignment (one of true or false). False by default.
	/// </summary>
	/// <value>(optional) Whether or not the app should use VPP by device assignment (one of true or false). False by default.</value>
	[DataMember(Name = "usesVPP")]
	public bool? UsesVPP { get; set; }
}
