namespace Meraki.Api.Data;

/// <summary>
/// DNS servers rewrite settings
/// </summary>
[DataContract]
public class DnsRewrite
{
	/// <summary>
	/// Boolean indicating whether or not DNS server rewrite is enabled. If disabled, upstream DNS will be used
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }

	/// <summary>
	/// User specified DNS servers (up to two servers)
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "dnsCustomNameservers")]
	public List<string> DnsCustomNameservers { get; set; } = new();

	/// <inheritdoc />
	public override string ToString()
		=> $"{string.Join(",", DnsCustomNameservers)}:{Enabled}";
}
