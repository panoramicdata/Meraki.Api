﻿namespace Meraki.Api.Data;

/// <summary>
/// A network
/// </summary>
[DataContract]
public class Network : NetworkOrConfigurationTemplate
{
	/// <summary>
	/// Specifies the maximum allowed length, in characters, for a name value.
	/// </summary>
	public const int MaxNameLength = 38;

	/// <summary>
	/// Product types
	/// </summary>
	[DataMember(Name = "productTypes")]
	[ApiAccess(ApiAccess.ReadCreate)]
	public override List<ProductType> ProductTypes { get; set; } = [];

	/// <summary>
	/// OrganizationId
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[ApiForeignKey(typeof(Organization))]
	[DataMember(Name = "organizationId")]
	public string OrganizationId { get; set; } = string.Empty;

	/// <summary>
	/// tags
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "tags")]
	public List<string> Tags { get; set; } = [];

	/// <summary>
	/// The ID of the template to which the network should be bound.
	/// null if not bound to a ConfigurationTemplate
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[ApiForeignKey(typeof(ConfigurationTemplate))]
	[DataMember(Name = "configTemplateId")]
	public string? ConfigurationTemplateId { get; set; }

	/// <summary>
	/// Notes
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "notes")]
	public string? Notes { get; set; }

	/// <summary>
	/// A unique identifier which can be used for device enrollment or
	/// easy access through the Meraki SM Registration page or the
	/// Self Service Portal. Please note that changing this field may
	/// cause existing bookmarks to break.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enrollmentString")]
	public string? EnrollmentString { get; set; }

	/// <summary>
	/// IsBoundToConfigTemplate
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "isBoundToConfigTemplate")]
	public bool? IsBoundToConfigTemplate { get; set; }

	/// <summary>
	/// IsVirtual
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "isVirtual")]
	public bool? IsVirtual { get; set; }
}
