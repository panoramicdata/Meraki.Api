namespace Meraki.Api.Data;

/// <summary>
/// The type of splash page for the SSID ('None', 'Click-through splash page', 'Billing', 'Password-protected with Meraki RADIUS', 'Password-protected with custom RADIUS', 'Password-protected with Active Directory', 'Password-protected with LDAP', 'SMS authentication', 'Systems Manager Sentry', 'Facebook Wi-Fi', 'Google OAuth', 'Sponsored guest', 'Cisco ISE' or 'Google Apps domain'). This attribute is not supported for template children.
/// /// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum SplashPage
{
	/// <summary>
	/// None
	/// </summary>
	[EnumMember(Value = "None")]
	None,

	/// <summary>
	/// Click-through splash page
	/// </summary>
	[EnumMember(Value = "Click-through splash page")]
	Clickthroughsplashpage,

	/// <summary>
	/// Enum Billing for "Billing"
	/// </summary>
	[EnumMember(Value = "Billing")]
	Billing,

	/// <summary>
	/// Password-protected with Meraki RADIUS
	/// </summary>
	[EnumMember(Value = "Password-protected with Meraki RADIUS")]
	PasswordprotectedwithMerakiRADIUS,

	/// <summary>
	/// Password-protected with custom RADIUS
	/// </summary>
	[EnumMember(Value = "Password-protected with custom RADIUS")]
	PasswordprotectedwithcustomRADIUS,

	/// <summary>
	/// Password-protected with Active Directory
	/// </summary>
	[EnumMember(Value = "Password-protected with Active Directory")]
	PasswordprotectedwithActiveDirectory,

	/// <summary>
	/// Password-protected with LDAP
	/// </summary>
	[EnumMember(Value = "Password-protected with LDAP")]
	PasswordprotectedwithLDAP,

	/// <summary>
	/// SMS authentication
	/// </summary>
	[EnumMember(Value = "SMS authentication")]
	SMSauthentication,

	/// <summary>
	/// Systems Manager Sentry
	/// </summary>
	[EnumMember(Value = "Systems Manager Sentry")]
	SystemsManagerSentry,

	/// <summary>
	/// Facebook Wi-Fi
	/// </summary>
	[EnumMember(Value = "Facebook Wi-Fi")]
	FacebookWiFi,

	/// <summary>
	/// Google OAuth
	/// </summary>
	[EnumMember(Value = "Google OAuth")]
	GoogleOAuth,

	/// <summary>
	/// Sponsored guest
	/// </summary>
	[EnumMember(Value = "Sponsored guest")]
	SponsoredGuest,

	/// <summary>
	/// Cisco ISE
	/// </summary>
	[EnumMember(Value = "Cisco ISE")]
	CiscoISE,

	/// <summary>
	/// Google Apps domain
	/// </summary>
	[EnumMember(Value = "Google Apps domain")]
	GoogleAppsDomain
}
