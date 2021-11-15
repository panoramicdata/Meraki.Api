using System;
using System.Runtime.Serialization;

namespace Meraki.Api.Data;

[DataContract]
public class Software
{
	[DataMember(Name = "appId")]
	public string AppId { get; set; } = string.Empty;

	[DataMember(Name = "bundleSize")]
	public object BundleSize { get; set; } = new();

	[DataMember(Name = "createdAt")]
	public DateTime CreatedAt { get; set; }

	[DataMember(Name = "deviceId")]
	public string DeviceId { get; set; } = string.Empty;

	[DataMember(Name = "dynamicSize")]
	public object DynamicSize { get; set; } = new();

	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	[DataMember(Name = "identifier")]
	public string Identifier { get; set; } = string.Empty;

	[DataMember(Name = "installedAt")]
	public DateTime InstalledAt { get; set; }

	[DataMember(Name = "toInstall")]
	public object ToInstall { get; set; } = new();

	[DataMember(Name = "iosRedemptionCode")]
	public object IosRedemptionCode { get; set; } = new();

	[DataMember(Name = "isManaged")]
	public bool IsManaged { get; set; }

	[DataMember(Name = "itunesId")]
	public object ItunesId { get; set; } = new();

	[DataMember(Name = "licenseKey")]
	public object LicenseKey { get; set; } = new();

	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	[DataMember(Name = "path")]
	public string Path { get; set; } = string.Empty;

	[DataMember(Name = "redemptionCode")]
	public object RedemptionCode { get; set; } = new();

	[DataMember(Name = "shortVersion")]
	public object ShortVersion { get; set; } = new();

	[DataMember(Name = "status")]
	public object Status { get; set; } = new();

	[DataMember(Name = "toUninstall")]
	public bool ToUninstall { get; set; }

	[DataMember(Name = "uninstalledAt")]
	public object UninstalledAt { get; set; } = new();

	[DataMember(Name = "updatedAt")]
	public DateTime UpdatedAt { get; set; }

	[DataMember(Name = "vendor")]
	public string Vendor { get; set; } = string.Empty;

	[DataMember(Name = "version")]
	public string Version { get; set; } = string.Empty;
}
