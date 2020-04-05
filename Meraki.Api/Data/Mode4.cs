using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Either 'renew' or 'addDevices'. 'addDevices' will increase the license limit, while 'renew' will extend the amount of time until expiration. This parameter is legacy and only applies to coterm licensing; it should not be specified when claiming per-device licenses. Please see <a target='_blank' href='https://documentation.meraki.com/zGeneral_Administration/Licensing/Adding_an_Enterprise_license_to_an_existing_Dashboard_account'>this article</a> for more information.
	/// </summary>
	/// <value>Either 'renew' or 'addDevices'. 'addDevices' will increase the license limit, while 'renew' will extend the amount of time until expiration. This parameter is legacy and only applies to coterm licensing; it should not be specified when claiming per-device licenses. Please see <a target='_blank' href='https://documentation.meraki.com/zGeneral_Administration/Licensing/Adding_an_Enterprise_license_to_an_existing_Dashboard_account'>this article</a> for more information.</value>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum Mode4
	{

		/// <summary>
		/// Enum AddDevices for "addDevices"
		/// </summary>
		[EnumMember(Value = "addDevices")]
		AddDevices,

		/// <summary>
		/// Enum Renew for "renew"
		/// </summary>
		[EnumMember(Value = "renew")]
		Renew
	}
}
