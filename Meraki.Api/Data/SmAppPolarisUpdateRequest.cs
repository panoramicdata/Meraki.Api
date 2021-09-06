using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkSmAppPolaris
	/// </summary>
	[DataContract]
	public class SmAppPolarisUpdateRequest
	{
		/// <summary>
		/// optional: The scope (one of all, none, automatic, withAny, withAll, withoutAny, or withoutAll) and a set of tags of the devices to be assigned
		/// </summary>
		/// <value>optional: The scope (one of all, none, automatic, withAny, withAll, withoutAny, or withoutAll) and a set of tags of the devices to be assigned</value>
		[DataMember(Name = "scope")]
		public string Scope { get; set; } = string.Empty;
		/// <summary>
		/// optional: Whether or not SM should auto-install this app (one of true or false)
		/// </summary>
		/// <value>optional: Whether or not SM should auto-install this app (one of true or false)</value>
		[DataMember(Name = "preventAutoInstall")]
		public bool? PreventAutoInstall { get; set; }
		/// <summary>
		/// optional: Whether or not the app should use VPP by device assignment (one of true or false)
		/// </summary>
		/// <value>optional: Whether or not the app should use VPP by device assignment (one of true or false)</value>
		[DataMember(Name = "usesVPP")]
		public bool? UsesVPP { get; set; }
	}
}
