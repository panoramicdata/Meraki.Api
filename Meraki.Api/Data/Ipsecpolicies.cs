using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// IPSEC policies
	/// </summary>
	[DataContract]
	public class IpsecPolicies
	{
		/// <summary>
		/// The ikeCipherAlgo
		/// </summary>
		[DataMember(Name = "ikeCipherAlgo")]
		public List<string> IkeCipherAlgorithm { get; set; } = new List<string>();

		/// <summary>
		/// The ikeAuthAlgo
		/// </summary>
		[DataMember(Name = "ikeAuthAlgo")]
		public List<string> IkeAuthAlgorithm { get; set; } = new List<string>();

		/// <summary>
		/// The ikeDiffieHellmanGroup
		/// </summary>
		[DataMember(Name = "ikeDiffieHellmanGroup")]
		public List<string> IkeDiffieHellmanGroup { get; set; } = new List<string>();

		/// <summary>
		/// The ikeLifetime
		/// </summary>
		[DataMember(Name = "ikeLifetime")]
		public int IkeLifetime { get; set; }

		/// <summary>
		/// The childCipherAlgo
		/// </summary>
		[DataMember(Name = "childCipherAlgo")]
		public List<string> ChildCipherAlgorithm { get; set; } = new List<string>();

		/// <summary>
		/// The childAuthAlgo
		/// </summary>
		[DataMember(Name = "childAuthAlgo")]
		public List<string> ChildAuthAlgorithm { get; set; } = new List<string>();

		/// <summary>
		/// The childPfsGroup
		/// </summary>
		[DataMember(Name = "childPfsGroup")]
		public List<string> ChildPfsGroup { get; set; } = new List<string>();

		/// <summary>
		/// The childLifetime
		/// </summary>
		[DataMember(Name = "childLifetime")]
		public int ChildLifetime { get; set; }
	}
}