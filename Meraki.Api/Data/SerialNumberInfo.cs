namespace Meraki.Api.Data;

public class SerialNumberInfo
{
	public string SerialNumber { get; internal set; } = string.Empty;

	public string Model { get; internal set; } = string.Empty;

	public ProductType ProductType { get; internal set; }

	public bool IsVirtual { get; internal set; }
	public DateTime? EndOfSale { get; internal set; }
	public DateTime? EndOfSupport { get; internal set; }
	public string? EndOfSaleNoticeUrl { get; internal set; }
}
