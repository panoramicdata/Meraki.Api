using Newtonsoft.Json;
using System;using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Settings that will be enabled if selectionType is set to &#39;ap&#39;.
	/// </summary>
	[DataContract]
	public partial class ApBandSettings : IEquatable<ApBandSettings>, IValidatableObject
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ApBandSettings" /> class.
		/// </summary>
		/// <param name="BandOperationMode">BandOperationMode.</param>
		/// <param name="BandSteeringEnabled">Steers client to most open band. Can be either true or false. Defaults to true..</param>
		public ApBandSettings(BandOperationMode BandOperationMode = default, bool? BandSteeringEnabled = default)
		{
			this.BandOperationMode = BandOperationMode;
			this.BandSteeringEnabled = BandSteeringEnabled;
		}

		/// <summary>
		/// Gets or Sets BandOperationMode
		/// </summary>
		[DataMember(Name = "bandOperationMode", EmitDefaultValue = false)]
		public BandOperationMode BandOperationMode { get; set; }
		/// <summary>
		/// Steers client to most open band. Can be either true or false. Defaults to true.
		/// </summary>
		/// <value>Steers client to most open band. Can be either true or false. Defaults to true.</value>
		[DataMember(Name = "bandSteeringEnabled", EmitDefaultValue = false)]
		public bool? BandSteeringEnabled { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ApBandSettings {\n");
			sb.Append("  BandOperationMode: ").Append(BandOperationMode).Append("\n");
			sb.Append("  BandSteeringEnabled: ").Append(BandSteeringEnabled).Append("\n");
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
			return Equals(obj as ApBandSettings);
		}

		/// <summary>
		/// Returns true if ApBandSettings instances are equal
		/// </summary>
		/// <param name="other">Instance of ApBandSettings to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ApBandSettings other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			return other == null
					? false
					: (
						  BandOperationMode == other.BandOperationMode ||
						  BandOperationMode != null &&
						  BandOperationMode.Equals(other.BandOperationMode)
					 ) &&
					 (
						  BandSteeringEnabled == other.BandSteeringEnabled ||
						  BandSteeringEnabled != null &&
						  BandSteeringEnabled.Equals(other.BandSteeringEnabled)
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
				if (BandOperationMode != null)
					hash = hash * 59 + BandOperationMode.GetHashCode();
				if (BandSteeringEnabled != null)
					hash = hash * 59 + BandSteeringEnabled.GetHashCode();
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