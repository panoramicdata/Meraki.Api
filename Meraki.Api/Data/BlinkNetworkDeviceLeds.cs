using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// BlinkNetworkDeviceLeds
	/// </summary>
	[DataContract]
	public partial class BlinkNetworkDeviceLeds : IEquatable<BlinkNetworkDeviceLeds>, IValidatableObject
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="BlinkNetworkDeviceLeds" /> class.
		/// </summary>
		/// <param name="Duration">The duration in seconds. Must be between 5 and 120. Default is 20 seconds.</param>
		/// <param name="Period">The period in milliseconds. Must be between 100 and 1000. Default is 160 milliseconds.</param>
		/// <param name="Duty">The duty cycle as the percent active. Must be between 10 and 90. Default is 50..</param>
		public BlinkNetworkDeviceLeds(int? Duration = default, int? Period = default, int? Duty = default)
		{
			this.Duration = Duration;
			this.Period = Period;
			this.Duty = Duty;
		}

		/// <summary>
		/// The duration in seconds. Must be between 5 and 120. Default is 20 seconds
		/// </summary>
		/// <value>The duration in seconds. Must be between 5 and 120. Default is 20 seconds</value>
		[DataMember(Name = "duration", EmitDefaultValue = false)]

		public int? Duration { get; set; }
		/// <summary>
		/// The period in milliseconds. Must be between 100 and 1000. Default is 160 milliseconds
		/// </summary>
		/// <value>The period in milliseconds. Must be between 100 and 1000. Default is 160 milliseconds</value>
		[DataMember(Name = "period", EmitDefaultValue = false)]
		public int? Period { get; set; }

		/// <summary>
		/// The duty cycle as the percent active. Must be between 10 and 90. Default is 50.
		/// </summary>
		/// <value>The duty cycle as the percent active. Must be between 10 and 90. Default is 50.</value>
		[DataMember(Name = "duty", EmitDefaultValue = false)]
		public int? Duty { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class BlinkNetworkDeviceLeds {\n");
			sb.Append("  Duration: ").Append(Duration).Append("\n");
			sb.Append("  Period: ").Append(Period).Append("\n");
			sb.Append("  Duty: ").Append(Duty).Append("\n");
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
			return Equals(obj as BlinkNetworkDeviceLeds);
		}

		/// <summary>
		/// Returns true if BlinkNetworkDeviceLeds instances are equal
		/// </summary>
		/// <param name="other">Instance of BlinkNetworkDeviceLeds to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(BlinkNetworkDeviceLeds other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			return other == null
					? false
					: (
						  Duration == other.Duration ||
						  Duration != null &&
						  Duration.Equals(other.Duration)
					 ) &&
					 (
						  Period == other.Period ||
						  Period != null &&
						  Period.Equals(other.Period)
					 ) &&
					 (
						  Duty == other.Duty ||
						  Duty != null &&
						  Duty.Equals(other.Duty)
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
				if (Duration != null)
					hash = hash * 59 + Duration.GetHashCode();
				if (Period != null)
					hash = hash * 59 + Period.GetHashCode();
				if (Duty != null)
					hash = hash * 59 + Duty.GetHashCode();
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
