using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Open api specs
	/// </summary>
	[DataContract]
	public class OpenApiSpecs
	{
		/// <summary>
		/// Swagger
		/// </summary>
		[DataMember(Name = "swagger")]
		public string Swagger { get; set; } = string.Empty;

		/// <summary>
		/// Info
		/// </summary>
		[DataMember(Name = "info")]
		public OpenApiInfo Info { get; set; } = new();

		/// <summary>
		/// Paths
		/// </summary>
		[DataMember(Name = "version")]
		public OpenApiPaths Version { get; set; } = new();
	}
}
