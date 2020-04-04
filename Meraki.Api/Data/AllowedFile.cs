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
	/// AllowedFile
	/// </summary>
	[DataContract]
	public partial class AllowedFile : IEquatable<AllowedFile>, IValidatableObject
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AllowedFile" /> class.
		/// </summary>
		[JsonConstructor]
		protected AllowedFile() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="AllowedFile" /> class.
		/// </summary>
		/// <param name="Sha256">The file sha256 hash to whitelist (required).</param>
		/// <param name="Comment">Comment about the whitelisted entity (required).</param>
		public AllowedFile(string Sha256 = default, string Comment = default)
		{
			// to ensure "Sha256" is required (not null)
			if (Sha256 == null)
			{
				throw new InvalidDataException("Sha256 is a required property for AllowedFile and cannot be null");
			}
			else
			{
				this.Sha256 = Sha256;
			}
			// to ensure "Comment" is required (not null)
			if (Comment == null)
			{
				throw new InvalidDataException("Comment is a required property for AllowedFile and cannot be null");
			}
			else
			{
				this.Comment = Comment;
			}
		}

		/// <summary>
		/// The file sha256 hash to whitelist
		/// </summary>
		/// <value>The file sha256 hash to whitelist</value>
		[DataMember(Name = "sha256", EmitDefaultValue = false)]
		public string Sha256 { get; set; }
		/// <summary>
		/// Comment about the whitelisted entity
		/// </summary>
		/// <value>Comment about the whitelisted entity</value>
		[DataMember(Name = "comment", EmitDefaultValue = false)]
		public string Comment { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AllowedFile {\n");
			sb.Append("  Sha256: ").Append(Sha256).Append("\n");
			sb.Append("  Comment: ").Append(Comment).Append("\n");
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
			return Equals(obj as AllowedFile);
		}

		/// <summary>
		/// Returns true if AllowedFile instances are equal
		/// </summary>
		/// <param name="other">Instance of AllowedFile to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(AllowedFile other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			return other == null
					? false
					: (
						  Sha256 == other.Sha256 ||
						  Sha256 != null &&
						  Sha256.Equals(other.Sha256)
					 ) &&
					 (
						  Comment == other.Comment ||
						  Comment != null &&
						  Comment.Equals(other.Comment)
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
				if (Sha256 != null)
					hash = hash * 59 + Sha256.GetHashCode();
				if (Comment != null)
					hash = hash * 59 + Comment.GetHashCode();
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