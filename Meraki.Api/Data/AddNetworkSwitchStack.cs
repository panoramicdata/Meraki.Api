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
	/// AddNetworkSwitchStack
	/// </summary>
	[DataContract]
	public partial class AddNetworkSwitchStack : IEquatable<AddNetworkSwitchStack>, IValidatableObject
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AddNetworkSwitchStack" /> class.
		/// </summary>
		[JsonConstructor]
		protected AddNetworkSwitchStack() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="AddNetworkSwitchStack" /> class.
		/// </summary>
		/// <param name="Serial">The serial of the switch to be added (required).</param>
		public AddNetworkSwitchStack(string Serial = default)
		{
			// to ensure "Serial" is required (not null)
			if (Serial == null)
			{
				throw new InvalidDataException("Serial is a required property for AddNetworkSwitchStack and cannot be null");
			}
			else
			{
				this.Serial = Serial;
			}
		}

		/// <summary>
		/// The serial of the switch to be added
		/// </summary>
		/// <value>The serial of the switch to be added</value>
		[DataMember(Name = "serial", EmitDefaultValue = false)]
		public string Serial { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AddNetworkSwitchStack {\n");
			sb.Append("  Serial: ").Append(Serial).Append("\n");
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
			return Equals(obj as AddNetworkSwitchStack);
		}

		/// <summary>
		/// Returns true if AddNetworkSwitchStack instances are equal
		/// </summary>
		/// <param name="other">Instance of AddNetworkSwitchStack to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(AddNetworkSwitchStack other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			return other == null
					? false
					: Serial == other.Serial ||
						  Serial != null &&
						  Serial.Equals(other.Serial);
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
				if (Serial != null)
					hash = hash * 59 + Serial.GetHashCode();
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