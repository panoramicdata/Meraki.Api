namespace Meraki.Api.Data;

/// <summary>
/// Serial Number Info
/// </summary>
public class SerialNumberInfo
{
	/// <summary>
	/// Gets the serial number
	/// </summary>

	public string SerialNumber { get; internal set; } = string.Empty;

	/// <summary>
	/// Gets the model
	/// </summary>

	public string Model { get; internal set; } = string.Empty;

	/// <summary>
	/// Gets the product type
	/// </summary>

	public ProductType? ProductType { get; internal set; }

	/// <summary>
	/// Whether virtual
	/// </summary>

	public bool? IsVirtual { get; internal set; }

	/// <summary>
	/// Gets the end of sale
	/// </summary>

	public DateTimeOffset? EndOfSale { get; internal set; }

	/// <summary>
	/// Gets the end of support
	/// </summary>

	public DateTimeOffset? EndOfSupport { get; internal set; }

	/// <summary>
	/// Gets the end of sale notice url
	/// </summary>

	public string? EndOfSaleNoticeUrl { get; internal set; }
}
