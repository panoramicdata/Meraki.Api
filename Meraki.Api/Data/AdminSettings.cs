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
	/// Settings for describing which kinds of admins this policy applies to.
	/// </summary>
	[DataContract]
	public partial class AdminSettings : IEquatable<AdminSettings>, IValidatableObject
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AdminSettings" /> class.
		/// </summary>
		/// <param name="AppliesTo">AppliesTo.</param>
		/// <param name="Values">If &#39;appliesTo&#39; is set to one of &#39;Specific admins...&#39;, &#39;All admins of networks...&#39; or &#39;All admins of networks tagged...&#39;, then you must specify this &#39;values&#39; property to provide the set of     entities to apply the branding policy to. For &#39;Specific admins...&#39;, specify an array of admin IDs. For &#39;All admins of     networks...&#39;, specify an array of network IDs and/or configuration template IDs. For &#39;All admins of networks tagged...&#39;,     specify an array of tag names..</param>
		public AdminSettings(AppliesTo AppliesTo = default, List<string> Values = default)
		{
			this.AppliesTo = AppliesTo;
			this.Values = Values;
		}

		/// <summary>
		/// Gets or Sets AppliesTo
		/// </summary>
		[DataMember(Name = "appliesTo", EmitDefaultValue = false)]
		public AppliesTo AppliesTo { get; set; }
		/// <summary>
		/// If &#39;appliesTo&#39; is set to one of &#39;Specific admins...&#39;, &#39;All admins of networks...&#39; or &#39;All admins of networks tagged...&#39;, then you must specify this &#39;values&#39; property to provide the set of     entities to apply the branding policy to. For &#39;Specific admins...&#39;, specify an array of admin IDs. For &#39;All admins of     networks...&#39;, specify an array of network IDs and/or configuration template IDs. For &#39;All admins of networks tagged...&#39;,     specify an array of tag names.
		/// </summary>
		/// <value>If &#39;appliesTo&#39; is set to one of &#39;Specific admins...&#39;, &#39;All admins of networks...&#39; or &#39;All admins of networks tagged...&#39;, then you must specify this &#39;values&#39; property to provide the set of     entities to apply the branding policy to. For &#39;Specific admins...&#39;, specify an array of admin IDs. For &#39;All admins of     networks...&#39;, specify an array of network IDs and/or configuration template IDs. For &#39;All admins of networks tagged...&#39;,     specify an array of tag names.</value>
		[DataMember(Name = "values", EmitDefaultValue = false)]
		public List<string> Values { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AdminSettings {\n");
			sb.Append("  AppliesTo: ").Append(AppliesTo).Append("\n");
			sb.Append("  Values: ").Append(Values).Append("\n");
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
			return Equals(obj as AdminSettings);
		}

		/// <summary>
		/// Returns true if AdminSettings instances are equal
		/// </summary>
		/// <param name="other">Instance of AdminSettings to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(AdminSettings other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			return other == null
					? false
					: (
						  AppliesTo == other.AppliesTo ||
						  AppliesTo != null &&
						  AppliesTo.Equals(other.AppliesTo)
					 ) &&
					 (
						  Values == other.Values ||
						  Values != null &&
						  Values.SequenceEqual(other.Values)
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
				if (AppliesTo != null)
					hash = hash * 59 + AppliesTo.GetHashCode();
				if (Values != null)
					hash = hash * 59 + Values.GetHashCode();
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