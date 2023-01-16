namespace Meraki.Api.Data;

/// <summary>
/// Traffic filters
/// </summary>
[DataContract]
public class TrafficFilters
{
	/// <summary>
	/// Type of this traffic filter. Must be one of: 'applicationCategory', 'application' or 'custom'
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "type")]
	public TrafficFilterType? Type { get; set; }

	/// <summary>
	/// Value object of this traffic filter
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "value")]
	public TrafficFiltersValue? Value { get; set; }
}
