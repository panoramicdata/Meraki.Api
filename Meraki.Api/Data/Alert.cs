using Newtonsoft.Json;
using System;using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Alert
	/// </summary>
	[DataContract]
	public partial class Alert : IEquatable<Alert>, IValidatableObject
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Alert" /> class.
		/// </summary>
		[JsonConstructor]
		protected Alert() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="Alert" /> class.
		/// </summary>
		/// <param name="Type">The type of alert (required).</param>
		/// <param name="Enabled">A boolean depicting if the alert is turned on or off.</param>
		/// <param name="AlertDestinations">AlertDestinations.</param>
		/// <param name="Filters">A hash of specific configuration data for the alert. Only filters specific to the alert will be updated..</param>
		public Alert(string Type = default, bool? Enabled = default, AlertDestinations AlertDestinations = default, object Filters = default)
		{
			// to ensure "Type" is required (not null)
			if (Type == null)
			{
				throw new InvalidDataException("Type is a required property for Alert and cannot be null");
			}
			else
			{
				this.Type = Type;
			}
			this.Enabled = Enabled;
			this.AlertDestinations = AlertDestinations;
			this.Filters = Filters;
		}

		/// <summary>
		/// The type of alert
		/// </summary>
		/// <value>The type of alert</value>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public string Type { get; set; }
		/// <summary>
		/// A boolean depicting if the alert is turned on or off
		/// </summary>
		/// <value>A boolean depicting if the alert is turned on or off</value>
		[DataMember(Name = "enabled", EmitDefaultValue = false)]
		public bool? Enabled { get; set; }
		/// <summary>
		/// Gets or Sets AlertDestinations
		/// </summary>
		[DataMember(Name = "alertDestinations", EmitDefaultValue = false)]
		public AlertDestinations AlertDestinations { get; set; }
		/// <summary>
		/// A hash of specific configuration data for the alert. Only filters specific to the alert will be updated.
		/// </summary>
		/// <value>A hash of specific configuration data for the alert. Only filters specific to the alert will be updated.</value>
		[DataMember(Name = "filters", EmitDefaultValue = false)]
		public object Filters { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class Alert {\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  Enabled: ").Append(Enabled).Append("\n");
			sb.Append("  AlertDestinations: ").Append(AlertDestinations).Append("\n");
			sb.Append("  Filters: ").Append(Filters).Append("\n");
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
			return Equals(obj as Alert);
		}

		/// <summary>
		/// Returns true if Alert instances are equal
		/// </summary>
		/// <param name="other">Instance of Alert to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(Alert other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			return other == null
					? false
					: (
						  Type == other.Type ||
						  Type != null &&
						  Type.Equals(other.Type)
					 ) &&
					 (
						  Enabled == other.Enabled ||
						  Enabled != null &&
						  Enabled.Equals(other.Enabled)
					 ) &&
					 (
						  AlertDestinations == other.AlertDestinations ||
						  AlertDestinations != null &&
						  AlertDestinations.Equals(other.AlertDestinations)
					 ) &&
					 (
						  Filters == other.Filters ||
						  Filters != null &&
						  Filters.Equals(other.Filters)
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
				if (Type != null)
					hash = hash * 59 + Type.GetHashCode();
				if (Enabled != null)
					hash = hash * 59 + Enabled.GetHashCode();
				if (AlertDestinations != null)
					hash = hash * 59 + AlertDestinations.GetHashCode();
				if (Filters != null)
					hash = hash * 59 + Filters.GetHashCode();
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
