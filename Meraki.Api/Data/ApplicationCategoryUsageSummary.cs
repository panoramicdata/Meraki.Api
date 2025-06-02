namespace Meraki.Api.Data;

/// <summary>
/// Application Category Usage Summary
/// </summary>
[DataContract]
public class ApplicationCategoryUsageSummary
{
	/// <summary>
	/// Name of the Application Category
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "category")]
	public string Category { get; set; } = string.Empty;

	/// <summary>
	/// Downstream usage of the Application Category, in megabytes
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "downstream")]
	public int Downstream { get; set; }

	/// <summary>
	/// Percent usage of the Application Category
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "percentage")]
	public int Percentage { get; set; }

	/// <summary>
	/// Total usage of the Application Category, in megabytes
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "total")]
	public int Total { get; set; }

	/// <summary>
	/// Upstream usage of the Application Category, in megabytes
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "upstream")]
	public int Upstream { get; set; }
}
