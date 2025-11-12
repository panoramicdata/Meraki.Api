namespace Meraki.Api.Data;

/// <summary>
/// Software
/// </summary>
[ApiAccessReadOnlyClass]
[DataContract]
public class Software
{
	/// <summary>
	/// Gets the app id
	/// </summary>
	[DataMember(Name = "appId")]
	public string AppId { get; set; } = string.Empty;

	/// <summary>
	/// Gets the bundle size
	/// </summary>
	[DataMember(Name = "bundleSize")]
	public object BundleSize { get; set; } = new();

	/// <summary>
	/// Gets the created at
	/// </summary>
	[DataMember(Name = "createdAt")]
	public DateTime CreatedAt { get; set; }

	/// <summary>
	/// Gets the device id
	/// </summary>
	[DataMember(Name = "deviceId")]
	public string DeviceId { get; set; } = string.Empty;

	/// <summary>
	/// Gets the dynamic size
	/// </summary>
	[DataMember(Name = "dynamicSize")]
	public object DynamicSize { get; set; } = new();

	/// <summary>
	/// Gets the id
	/// </summary>
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Gets the identifier
	/// </summary>
	[DataMember(Name = "identifier")]
	public string Identifier { get; set; } = string.Empty;

	/// <summary>
	/// Gets the installed at
	/// </summary>
	[DataMember(Name = "installedAt")]
	public DateTime InstalledAt { get; set; }

	/// <summary>
	/// Gets the to install
	/// </summary>
	[DataMember(Name = "toInstall")]
	public object ToInstall { get; set; } = new();

	/// <summary>
	/// Gets the ios redemption code
	/// </summary>
	[DataMember(Name = "iosRedemptionCode")]
	public object IosRedemptionCode { get; set; } = new();

	/// <summary>
	/// Whether managed
	/// </summary>
	[DataMember(Name = "isManaged")]
	public bool IsManaged { get; set; }

	/// <summary>
	/// Gets the itunes id
	/// </summary>
	[DataMember(Name = "itunesId")]
	public object ItunesId { get; set; } = new();

	/// <summary>
	/// Gets the license key
	/// </summary>
	[DataMember(Name = "licenseKey")]
	public object LicenseKey { get; set; } = new();

	/// <summary>
	/// Gets the name
	/// </summary>
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Gets the path
	/// </summary>
	[DataMember(Name = "path")]
	public string Path { get; set; } = string.Empty;

	/// <summary>
	/// Gets the redemption code
	/// </summary>
	[DataMember(Name = "redemptionCode")]
	public object RedemptionCode { get; set; } = new();

	/// <summary>
	/// Gets the short version
	/// </summary>
	[DataMember(Name = "shortVersion")]
	public object ShortVersion { get; set; } = new();

	/// <summary>
	/// Gets the status
	/// </summary>
	[DataMember(Name = "status")]
	public object Status { get; set; } = new();

	/// <summary>
	/// Gets the to uninstall
	/// </summary>
	[DataMember(Name = "toUninstall")]
	public bool ToUninstall { get; set; }

	/// <summary>
	/// Gets the uninstalled at
	/// </summary>
	[DataMember(Name = "uninstalledAt")]
	public DateTime UninstalledAt { get; set; } = new();

	/// <summary>
	/// Gets the updated at
	/// </summary>
	[DataMember(Name = "updatedAt")]
	public DateTime UpdatedAt { get; set; }

	/// <summary>
	/// Gets the vendor
	/// </summary>
	[DataMember(Name = "vendor")]
	public string Vendor { get; set; } = string.Empty;

	/// <summary>
	/// Gets the version
	/// </summary>
	[DataMember(Name = "version")]
	public string Version { get; set; } = string.Empty;
}
