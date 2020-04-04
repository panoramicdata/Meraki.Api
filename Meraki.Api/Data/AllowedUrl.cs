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
	/// AllowedUrl
	/// </summary>
	[DataContract]
	public partial class AllowedUrl : IEquatable<AllowedUrl>, IValidatableObject
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AllowedUrl" /> class.
		/// </summary>
		[JsonConstructor]
		protected AllowedUrl() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="AllowedUrl" /> class.
		/// </summary>
		/// <param name="Url">The url to whitelist (required).</param>
		/// <param name="Comment">Comment about the whitelisted entity (required).</param>
		public AllowedUrl(string Url = default, string Comment = default)
		{
			// to ensure "Url" is required (not null)
			if (Url == null)
			{
				throw new InvalidDataException("Url is a required property for AllowedUrl and cannot be null");
			}
			else
			{
				this.Url = Url;
			}
			// to ensure "Comment" is required (not null)
			if (Comment == null)
			{
				throw new InvalidDataException("Comment is a required property for AllowedUrl and cannot be null");
			}
			else
			{
				this.Comment = Comment;
			}
		}

		/// <summary>
		/// The url to whitelist
		/// </summary>
		/// <value>The url to whitelist</value>
		[DataMember(Name = "url", EmitDefaultValue = false)]
		public string Url { get; set; }
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
			sb.Append("class AllowedUrl {\n");
			sb.Append("  Url: ").Append(Url).Append("\n");
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
			return Equals(obj as AllowedUrl);
		}

		/// <summary>
		/// Returns true if AllowedUrl instances are equal
		/// </summary>
		/// <param name="other">Instance of AllowedUrl to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(AllowedUrl other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			return other == null
					? false
					: (
						  Url == other.Url ||
						  Url != null &&
						  Url.Equals(other.Url)
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
				if (Url != null)
					hash = hash * 59 + Url.GetHashCode();
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
