namespace Meraki.Api.Data;

/// <summary>
/// Splash page settings
/// </summary>
[DataContract]
public class SsidSplashSettings
{
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "splashMethod")]
	public string? SplashMethod { get; set; }

	/// <summary>
	/// Ssid Number.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ssidNumber")]
	public int SsidNumber { get; set; }

	/// <summary>
	/// Splash timeout in minutes. This will determine how often users will see the splash page.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "splashTimeout")]
	public int SplashTimeout { get; set; }

	/// <summary>
	/// How login attempts should be handled when the controller is unreachable. Can be either 'open', 'restricted', or 'default
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "controllerDisconnectionBehavior")]
	public string? ControllerDisconnectBehavior { get; set; }

	/// <summary>
	/// The custom redirect URL where the users will go after the splash page.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "redirectUrl")]
	public string? RedirectUrl { get; set; } = string.Empty;

	/// <summary>
	/// [optional] The custom splash URL of the click-through splash page. Note that the URL can be configured without necessarily being used. In order to enable the custom URL, see 'useSplashUrl'
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "splashUrl")]
	public string? SplashUrl { get; set; } = string.Empty;

	/// <summary>
	/// The welcome message for the users on the splash page.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "welcomeMessage")]
	public string WelcomeMessage { get; set; } = string.Empty;

	/// <summary>
	/// Whether or not to allow simultaneous logins from different devices.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "allowSimultaneousLogins")]
	public bool? AllowSimultaneousLogins { get; set; }

	/// <summary>
	/// How restricted allowing traffic should be.If true, all traffic types are blocked until the splash page is acknowledged.If false, all non-HTTP traffic is allowed before the splash page is acknowledged
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "blockAllTrafficBeforeSignOn")]
	public bool BlockAllTrafficBeforeSignOn { get; set; }

	/// <summary>
	/// The Boolean indicating whether the user will be redirected to the custom redirect URL after the splash page. A custom redirect URL must be set if this is true.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "useRedirectUrl")]
	public bool UseRedirectUrl { get; set; }

	/// <summary>
	/// [optional] Boolean indicating whether the users will be redirected to the custom splash url. A custom splash URL must be set if this is true. Note that depending on your SSID's access control settings, it may not be possible to use the custom splash URL.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "useSplashUrl")]
	public bool? UseSplashUrl { get; set; }

	/// <summary>
	/// Details associated with billing splash.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "billing")]
	public Billing? Billing { get; set; }

	/// <summary>
	/// Details associated with guest sponsored splash.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "guestSponsorship")]
	public GuestSponsorship GuestSponsorship { get; set; } = new();

	/// <summary>
	/// Systems Manager sentry enrollment splash settings.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "sentryEnrollment")]
	public SentryEnrollment sentryEnrollment { get; set; } = new();

	/// <summary>
	/// The image used in the splash page.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "splashImage")]
	public SplashImage SplashImage { get; set; } = new();

	/// <summary>
	/// The logo used in the splash page.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "splashLogo")]
	public SplashImage SplashLogo { get; set; } = new();

	/// <summary>
	/// The prepaid front image used in the splash page.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "splashPrepaidFront")]
	public SplashImage SplashPrepaidFront { get; set; } = new();
}
