using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Splash page settings
	/// </summary>
	[DataContract]
	public class SsidSplashSettings
	{
		/// <summary>
		/// Splash timeout
		/// </summary>
		[DataMember(Name = "splashTimeout")]
		public int SplashTimeout { get; set; }

		/// <summary>
		/// Controller disconnection behavior
		/// </summary>
		[DataMember(Name = "controllerDisconnectionBehavior")]
		public string? ControllerDisconnectBehavior { get; set; }

		/// <summary>
		/// Redirect URL
		/// </summary>
		[DataMember(Name = "redirectUrl")]
		public string? RedirectUrl { get; set; } = string.Empty;

		/// <summary>
		/// Welcome message
		/// </summary>
		[DataMember(Name = "welcomeMessage")]
		public string WelcomeMessage { get; set; } = string.Empty;

		/// <summary>
		/// Allow simultaneous logins
		/// </summary>
		[DataMember(Name = "allowSimultaneousLogins")]
		public bool? AllowSimultaneousLogins { get; set; }

		/// <summary>
		/// Block all traffic before sign on
		/// </summary>
		[DataMember(Name = "blockAllTrafficBeforeSignOn")]
		public bool BlockAllTrafficBeforeSignOn { get; set; }

		/// <summary>
		/// Use redirect url
		/// </summary>
		[DataMember(Name = "useRedirectUrl")]
		public bool UseRedirectUrl { get; set; }

		/// <summary>
		/// Use splash url
		/// </summary>
		[DataMember(Name = "useSplashUrl")]
		public bool UseSplashUrl { get; set; }

		/// <summary>
		/// Billing
		/// </summary>
		[DataMember(Name = "billing")]
		public Billing? Billing { get; set; }

		/// <summary>
		/// Guest sponsorship
		/// </summary>
		[DataMember(Name = "guestSponsorship")]
		public GuestSponsorship? GuestSponsorship { get; set; }

		/// <summary>
		/// Splash image
		/// </summary>
		[DataMember(Name = "splashImage")]
		public SplashImage SplashImage { get; set; } = new();

		/// <summary>
		/// Splash logo
		/// </summary>
		[DataMember(Name = "splashLogo")]
		public SplashImage SplashLogo { get; set; } = new();

		/// <summary>
		/// Splash prepaid front
		/// </summary>
		[DataMember(Name = "splashPrepaidFront")]
		public SplashImage SplashPrepaidFront { get; set; } = new();
	}
}
