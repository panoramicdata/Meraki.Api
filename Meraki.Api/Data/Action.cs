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
	/// Action
	/// </summary>
	[DataContract]
	public partial class Action : IEquatable<Action>, IValidatableObject
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Action" /> class.
		/// </summary>
		[JsonConstructor]
		protected Action() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="Action" /> class.
		/// </summary>
		/// <param name="Resource">Unique identifier for the resource to be acted on (required).</param>
		/// <param name="Operation">The operation to be used (required).</param>
		/// <param name="Body">The body of the action.</param>
		public Action(string Resource = default, string Operation = default, object Body = default)
		{
			// to ensure "Resource" is required (not null)
			if (Resource == null)
			{
				throw new InvalidDataException("Resource is a required property for Action and cannot be null");
			}
			else
			{
				this.Resource = Resource;
			}
			// to ensure "Operation" is required (not null)
			if (Operation == null)
			{
				throw new InvalidDataException("Operation is a required property for Action and cannot be null");
			}
			else
			{
				this.Operation = Operation;
			}
			this.Body = Body;
		}

		/// <summary>
		/// Unique identifier for the resource to be acted on
		/// </summary>
		/// <value>Unique identifier for the resource to be acted on</value>
		[DataMember(Name = "resource", EmitDefaultValue = false)]
		public string Resource { get; set; }

		/// <summary>
		/// The operation to be used
		/// </summary>
		/// <value>The operation to be used</value>
		[DataMember(Name = "operation", EmitDefaultValue = false)]
		public string Operation { get; set; }

		/// <summary>
		/// The body of the action
		/// </summary>
		/// <value>The body of the action</value>
		[DataMember(Name = "body", EmitDefaultValue = false)]
		public object Body { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		///
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class Action {\n");
			sb.Append("  Resource: ").Append(Resource).Append("\n");
			sb.Append("  Operation: ").Append(Operation).Append("\n");
			sb.Append("  Body: ").Append(Body).Append("\n");
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
			return Equals(obj as Action);
		}

		/// <summary>
		/// Returns true if Action instances are equal
		/// </summary>
		/// <param name="other">Instance of Action to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(Action other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			return other == null
				? false
				: (
					  Resource == other.Resource ||
					  Resource != null &&
					  Resource.Equals(other.Resource)
				 ) &&
				 (
					  Operation == other.Operation ||
					  Operation != null &&
					  Operation.Equals(other.Operation)
				 ) &&
				 (
					  Body == other.Body ||
					  Body != null &&
					  Body.Equals(other.Body)
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
				if (Resource != null)
					hash = hash * 59 + Resource.GetHashCode();
				if (Operation != null)
					hash = hash * 59 + Operation.GetHashCode();
				if (Body != null)
					hash = hash * 59 + Body.GetHashCode();
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