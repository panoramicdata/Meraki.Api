using Meraki.Api.Attributes;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// Custom IPSec policies for the VPN peer. If not included and a preset has not been chosen, the default preset for IPSec policies will be used.
/// </summary>
[DataContract]
public class IpsecPolicies
{
	/// <summary>
	/// This is the cipher algorithm to be used in Phase 1. The value should be an array with one of the following algorithms: 'aes256', 'aes192', 'aes128', 'tripledes', 'des'
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "ikeCipherAlgo")]
	public List<string> IkeCipherAlgorithm { get; set; } = new List<string>();

	/// <summary>
	/// This is the authentication algorithm to be used in Phase 1. The value should be an array with one of the following algorithms: 'sha256', 'sha1', 'md5'
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "ikeAuthAlgo")]
	public List<string> IkeAuthAlgorithm { get; set; } = new List<string>();

	/// <summary>
	/// [optional] This is the pseudo-random function to be used in IKE_SA. The value should be an array with one of the following algorithms: 'prfsha256', 'prfsha1', 'prfmd5', 'default'. The 'default' option can be used to default to the Authentication algorithm.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "ikePrfAlgo")]
	public List<string>? ikePrfAlgo { get; set; }

	/// <summary>
	/// This is the Diffie-Hellman group to be used in Phase 1. The value should be an array with one of the following algorithms: 'group14', 'group5', 'group2', 'group1'
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "ikeDiffieHellmanGroup")]
	public List<string> IkeDiffieHellmanGroup { get; set; } = new List<string>();

	/// <summary>
	/// The lifetime of the Phase 1 SA in seconds.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "ikeLifetime")]
	public int IkeLifetime { get; set; }

	/// <summary>
	/// This is the cipher algorithms to be used in Phase 2. The value should be an array with one or more of the following algorithms: 'aes256', 'aes192', 'aes128', 'tripledes', 'des', 'null'
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "childCipherAlgo")]
	public List<string> ChildCipherAlgorithm { get; set; } = new List<string>();

	/// <summary>
	/// This is the authentication algorithms to be used in Phase 2. The value should be an array with one of the following algorithms: 'sha256', 'sha1', 'md5'
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "childAuthAlgo")]
	public List<string> ChildAuthAlgorithm { get; set; } = new List<string>();

	/// <summary>
	/// This is the Diffie-Hellman group to be used for Perfect Forward Secrecy in Phase 2. The value should be an array with one of the following values: 'disabled','group14', 'group5', 'group2', 'group1'
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "childPfsGroup")]
	public List<string> ChildPfsGroup { get; set; } = new List<string>();

	/// <summary>
	/// The lifetime of the Phase 2 SA in seconds.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "childLifetime")]
	public int ChildLifetime { get; set; }
}
