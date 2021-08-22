﻿using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Alternate management interface
	/// </summary>
	[DataContract]
	public class WirelessAlternateManagementInterface
	{
		/// <summary>
		/// Boolean value to enable or disable alternate management interface
		/// </summary>
		[DataMember(Name = "enabled")]
		public bool Enabled { get; set; }

		/// <summary>
		/// Alternate management interface VLAN, must be between 1 and 4094
		/// </summary>
		[DataMember(Name = "vlanId")]
		public int VlanId { get; set; } = 0;

		/// <summary>
		/// Can be one or more of the following values: 'radius', 'snmp', 'syslog' or 'ldap'
		/// </summary>
		[DataMember(Name = "protocols")]
		public List<string> Protocols { get; set; } = new();

		/// <summary>
		/// Array of access point serial number and IP assignment. Note: accessPoints IP assignment is not applicable for template networks, in other words, do not put 'accessPoints' in the body when updating template networks. Also, an empty 'accessPoints' array will remove all previous static IP assignments
		/// </summary>
		[DataMember(Name = "accessPoints")]
		public List<AccessPoints> AccessPoints { get; set; } = new();
	}
}