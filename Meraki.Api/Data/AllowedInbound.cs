using Newtonsoft.Json;
using System;using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// AllowedInbound
	/// </summary>
	[DataContract]
	public partial class AllowedInbound : IEquatable<AllowedInbound>, IValidatableObject
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AllowedInbound" /> class.
		/// </summary>
		/// <param name="Protocol">Protocol.</param>
		/// <param name="DestinationPorts">An array of ports or port ranges that will be forwarded to the host on the LAN.</param>
		/// <param name="AllowedIps">An array of ranges of WAN IP addresses that are allowed to make inbound connections on the specified ports or port ranges, or &#39;any&#39;.</param>
		public AllowedInbound(Protocol4 Protocol = default, List<string> DestinationPorts = default, List<string> AllowedIps = default)
		{
			this.Protocol = Protocol;
			this.DestinationPorts = DestinationPorts;
			this.AllowedIps = AllowedIps;
		}

		/// <summary>
		/// Gets or Sets Protocol
		/// </summary>
		[DataMember(Name = "protocol", EmitDefaultValue = false)]
		public Protocol4 Protocol { get; set; }
		/// <summary>
		/// An array of ports or port ranges that will be forwarded to the host on the LAN
		/// </summary>
		/// <value>An array of ports or port ranges that will be forwarded to the host on the LAN</value>
		[DataMember(Name = "destinationPorts", EmitDefaultValue = false)]
		public List<string> DestinationPorts { get; set; }
		/// <summary>
		/// An array of ranges of WAN IP addresses that are allowed to make inbound connections on the specified ports or port ranges, or &#39;any&#39;
		/// </summary>
		/// <value>An array of ranges of WAN IP addresses that are allowed to make inbound connections on the specified ports or port ranges, or &#39;any&#39;</value>
		[DataMember(Name = "allowedIps", EmitDefaultValue = false)]
		public List<string> AllowedIps { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AllowedInbound {\n");
			sb.Append("  Protocol: ").Append(Protocol).Append("\n");
			sb.Append("  DestinationPorts: ").Append(DestinationPorts).Append("\n");
			sb.Append("  AllowedIps: ").Append(AllowedIps).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}

		/// <summary>
		/// Returns the JSON string presentation of the object
		/// </summary>
		/// <returns>JSON string presentation of the object</returns>
		public string ToJson()
		{
			return JsonConvert.SerializeObject(this, Formatting.Indented);
		}

		/// <summary>
		/// Returns true if objects are equal
		/// </summary>
		/// <param name="obj">Object to be compared</param>
		/// <returns>Boolean</returns>
		public override bool Equals(object obj)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			return Equals(obj as AllowedInbound);
		}

		/// <summary>
		/// Returns true if AllowedInbound instances are equal
		/// </summary>
		/// <param name="other">Instance of AllowedInbound to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(AllowedInbound other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			return other == null
					? false
					: (
						  Protocol == other.Protocol ||
						  Protocol != null &&
						  Protocol.Equals(other.Protocol)
					 ) &&
					 (
						  DestinationPorts == other.DestinationPorts ||
						  DestinationPorts != null &&
						  DestinationPorts.SequenceEqual(other.DestinationPorts)
					 ) &&
					 (
						  AllowedIps == other.AllowedIps ||
						  AllowedIps != null &&
						  AllowedIps.SequenceEqual(other.AllowedIps)
					 );
		}

		/// <summary>
		/// Gets the hash code
		/// </summary>
		/// <returns>Hash code</returns>
		public override int GetHashCode()
		{
			// credit: http://stackoverflow.com/a/263416/677735
			unchecked // Overflow is fine, just wrap
			{
				int hash = 41;
				// Suitable nullity checks etc, of course :)
				if (Protocol != null)
					hash = hash * 59 + Protocol.GetHashCode();
				if (DestinationPorts != null)
					hash = hash * 59 + DestinationPorts.GetHashCode();
				if (AllowedIps != null)
					hash = hash * 59 + AllowedIps.GetHashCode();
				return hash;
			}
		}

		/// <summary>
		/// To validate all properties of the instance
		/// </summary>
		/// <param name="validationContext">Validation context</param>
		/// <returns>Validation Result</returns>
		IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
		{
			yield break;
		}
	}
}