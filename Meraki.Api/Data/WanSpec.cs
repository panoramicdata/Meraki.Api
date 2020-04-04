using System;using System.Threading.Tasks;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// WAN specification
	/// </summary>
	[DataContract]
	public class WanSpec
	{
		/// <summary>
		/// Wan enabled
		/// </summary>
		[SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Workaround for Refit's lack of string enum handling")]
		[SuppressMessage("Design", "CA1051:Do not declare visible instance fields", Justification = "Workaround for Refit's lack of string enum handling")]
		public WanEnabledStatus WanEnabled;

		[DataMember(Name = "wanEnabled")]
		public string WanEnabledStatusString
		{
			get
			{
				return WanEnabled switch
				{
					WanEnabledStatus.Enabled => "enabled",
					WanEnabledStatus.Disabled => "disabled",
					WanEnabledStatus.NotConfigured => "not configured",
					_ => throw new NotSupportedException($"Missing enum {WanEnabled}"),
				};
			}
			set
			{
				WanEnabled = value switch
				{
					"enabled" => WanEnabledStatus.Enabled,
					"disabled" => WanEnabledStatus.Disabled,
					"not configured" => WanEnabledStatus.NotConfigured,
					_ => throw new NotSupportedException($"Missing enum {value}"),
				};
			}
		}

		/// <summary>
		/// Using static IP
		/// </summary>
		[DataMember(Name = "usingStaticIp")]
		public bool UsingStaticIp { get; set; }

		/// <summary>
		/// Static IP
		/// </summary>
		[DataMember(Name = "staticIp")]
		public string StaticIp { get; set; } = string.Empty;

		/// <summary>
		/// Static subnet mask
		/// </summary>
		[DataMember(Name = "staticSubnetMask")]
		public string StaticSubnetMask { get; set; } = string.Empty;

		/// <summary>
		/// Static gateway IP
		/// </summary>
		[DataMember(Name = "staticGatewayIp")]
		public string StaticGatewayIp { get; set; } = string.Empty;

		/// <summary>
		/// Static DNS
		/// </summary>
		[DataMember(Name = "staticDns")]
		public List<string>? StaticDns { get; set; }

		/// <summary>
		/// VLAN id
		/// </summary>
		[DataMember(Name = "vlan")]
		public int? Vlan { get; set; }
	}
}
