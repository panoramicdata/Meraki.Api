using Newtonsoft.Json.Linq;

namespace Meraki.Api;

/// <summary>
/// A Meraki Dashboard API client!
/// </summary>
public partial class MerakiClient
{
	// Information from https://community.meraki.com/t5/Developers-APIs/Serial-number-to-Device-Type/m-p/199859
	// ...and other contributors.
	private static readonly Dictionary<string, string> _serialNumberModels = new()
	{
		{ "Q2AP", "MS22" },
		{ "Q2AT", "MC74" },
		{ "Q2AW", "MS410-16" },
		{ "Q2AX", "MS120-8" },
		{ "Q2AZ", "vMX100" },
		{ "Q2BV", "MV21" },
		{ "Q2BW", "MS410-32" },
		{ "Q2BX", "MS120-8LP" },
		{ "Q2BY", "MS355-24X2" },
		{ "Q2BZ", "VMX-S" },
		{ "Q2CK", "MR66" },
		{ "Q2CN", "MX60W" },
		{ "Q2CW", "MS425-16" },
		{ "Q2CX", "MS120-8FP" },
		{ "Q2DD", "MR16" },
		{ "Q2DK", "MR72" },
		{ "Q2DW", "MS425-32" },
		{ "Q2DX", "MS120-24" },
		{ "Q2DY", "MS355-48X2" },
		{ "Q2DZ", "VMX-M" },
		{ "Q2EK", "MR84" },
		{ "Q2EN", "MX90" },
		{ "Q2EV", "MV12N" },
		{ "Q2EW", "MS350-24X" },
		{ "Q2EX", "MS120-24P" },
		{ "Q2EZ", "UMB-SIG" },
		{ "Q2FD", "MR34" },
		{ "Q2FN", "MX400" },
		{ "Q2FW", "MS225-24" },
		{ "Q2FV", "MV12WE" },
		{ "Q2FX", "MS120-48" },
		{ "Q2FY", "MX67" },
		{ "Q2FZ", "VMX-XL" },
		{ "Q2GD", "MR18" },
		{ "Q2GN", "MX600" },
		{ "Q2GV", "MV12W" },
		{ "Q2GW", "MS225-24P" },
		{ "Q2GX", "MS120-48LP" },
		{ "Q2GY", "MX67W" },
		{ "Q2GZ", "CPSC-HUB" },
		{ "Q2HD", "MR26" },
		{ "Q2HN", "Z1" },
		{ "Q2HP", "MS220-8P" },
		{ "Q2HV", "MV22" },
		{ "Q2HW", "MS225-48" },
		{ "Q2HY", "MX67C-NA" },
		{ "Q2JD", "MR32" },
		{ "Q2JN", "MX100" },
		{ "Q2JP", "MS220-24" },
		{ "Q2JV", "MV72" },
		{ "Q2JW", "MS225-48LP" },
		{ "Q2JY", "MX67C-WW" },
		{ "Q2KD", "MR42" },
		{ "Q2KN", "MX64" },
		{ "Q2KP", "MS220-24P" },
		{ "Q2KW", "MS225-48FP" },
		{ "Q2KY", "MX68" },
		{ "Q2LD", "MR52" },
		{ "Q2LP", "MS220-48" },
		{ "Q2LW", "MS250-24" },
		{ "Q2LY", "MX68W" },
		{ "Q2MD", "MR53" },
		{ "Q2MN", "MX64W" },
		{ "Q2MP", "MS220-48LP" },
		{ "Q2MV", "MV52" },
		{ "Q2MW", "MS250-24P" },
		{ "Q2MY", "MX68CW-NA" },
		{ "Q2NP", "MS220-48FP" },
		{ "Q2NV", "MV2" },
		{ "Q2NY", "MX68CW-WW" },
		{ "Q2PD", "MR33" },
		{ "Q2PN", "MX84" },
		{ "Q2PV", "MV32" },
		{ "Q2PW", "MS250-48LP" },
		{ "Q2PY", "Z3C-NA" },
		{ "Q2QD", "MR74" },
		{ "Q2QN", "MX65" },
		{ "Q2QP", "MS320-24P" },
		{ "Q2QW", "MS250-48FP" },
		{ "Q2QX", "MS120-48FP" },
		{ "Q2QY", "Z3C-HW-WW" },
		{ "Q2RD", "MR30H" },
		{ "Q2RN", "MX65W" },
		{ "Q2SV", "MV22X" },
		{ "Q2SX", "MS210-24P" },
		{ "Q2SW", "MX250" },
		{ "Q2TD", "MR42E" },
		{ "Q2TN", "Z3" },
		{ "Q2TP", "MS320-48FP" },
		{ "Q2TV", "MV72X" },
		{ "Q2TW", "MX450" },
		{ "Q2TY", "MG21E" },
		{ "Q2UD", "MR53E" },
		{ "Q2UX", "MS210-48LP" },
		{ "Q2UW", "MV63X" },
		{ "Q2UY", "MG21-NA" },
		{ "Q2VP", "MS350-24" },
		{ "Q2VX", "MS210-48FP" },
		{ "Q2WN", "MX105" },
		{ "Q2XD", "MR20" },
		{ "Q2XN", "MX95" },
		{ "Q2XP", "MS350-48" },
		{ "Q2YD", "MR70" },
		{ "Q2YN", "MX85" },
		{ "Q2YY", "MG41E" },
		{ "Q2ZD", "MR55" },
		{ "Q2ZP", "MS350-48FP" },
		{ "Q2ZY", "MG41" },
		{ "Q2ZZ", "C9X00" },

		{ "Q3AA", "MR45" },
		{ "Q3AB", "MR56" },
		{ "Q3AC", "MR46" },
		{ "Q3AD", "MR46E" },
		{ "Q3AE", "MR86" },
		{ "Q3AL", "MR44" },
		{ "Q3AJ", "MR36" },
		{ "Q3AK", "MR76" },
		{ "Q3AN", "MR36H" },
		{ "Q3AP", "MR57" },
		{ "Q3AS", "MR28" },
		{ "Q3AU", "MR78" },
		{ "Q3CA", "MT10" },
		{ "Q3CB", "MT12" },
		{ "Q3CC", "MT20" },
		{ "Q3CE", "MT11" },
		{ "Q3CG", "MT14" },
		{ "Q3CH", "MT30" },
		{ "Q3CJ", "MT40" },
		{ "Q3CQ", "MT15" },
		{ "Q3DA", "MS125-24" },
		{ "Q3DB", "MS125-24P" },
		{ "Q3DD", "MS125-48LP" },
		{ "Q3DE", "MS125-48FP" },
		{ "Q3EB", "MS390-24P" },
		{ "Q3ED", "MS390-24UX" },
		{ "Q3EF", "MS390-48P" },
		{ "Q3EH", "MS390-48UX" },
		{ "Q3EJ", "MS390-48UX2" },
		{ "Q3FA", "MX75" },
		{ "Q3FD", "Z4" },
		{ "Q3FE", "Z4C" },
		{ "Q3GA", "MG51" },
		{ "Q3GB", "MG51E" },
		{ "Q3GC", "MG52" },
		{ "Q3GD", "MG52E" },
		{ "Q3KA", "MR36" },
		{ "Q3LB", "MX105" },
		{ "Q3LE", "MX75" },
		{ "Q3LN", "MS130-8X" },
		{ "Q3LP", "MS130-12X" },
		{ "Q3LR", "MS130-24P" },
		{ "Q3LS", "MS130-24X" },
		{ "Q3LV", "MS130-48X" },

		{ "Q4AA", "MS120-8" },
		{ "Q4AB", "MS120-8LP" },
		{ "Q4AC", "MS120-8FP" },
		{ "Q4AE", "MS120-24P" },
		{ "Q4AG", "MS120-48LP" },
		{ "Q4AH", "MS120-48FP" },
		{ "Q4AS", "MS210-24P" },
		{ "Q4AT", "MS210-48" },
		{ "Q4AU", "MS210-48LP" },
		{ "Q4AV", "MS210-48FP" },
		{ "Q4BJ", "MS390-48UX2" },
		{ "Q4CB", "MS130-8P" },
		{ "Q4CC", "MS130-8X" },
		{ "Q4CD", "MS130-12X" },
		{ "Q4CJ", "MS130-48X" },
		{ "Q4DA", "MS120-8LP" },
		{ "Q4DB", "MS120-8FP" },
		{ "Q4DD", "MS120-24P" },
		{ "Q4DE", "MS120-24P" },
		{ "Q4DH", "MS120-48LP" },
		{ "Q4DJ", "MS120-48FP" },
		{ "Q4DN", "MS125-24P" },
		{ "Q4DR", "MS125-48LP" },
		{ "Q4DT", "MS125-48FP" },
		{ "Q4EB", "MV23X" },
		{ "Q4ED", "MV73X" },
		{ "Q4EE", "MV13" },
		{ "Q4EF", "MV33" },
		{ "Q4EG", "MV53X" },
		{ "Q4FA", "MS130R-8P" },
		{ "Q4GG", "MS150-24P" },
		{ "Q4GJ", "MS150-48LP" },
		{ "Q4GL", "MS150-24MP" },
		{ "Q4HF", "MX650" },

		{ "Q5AA", "CW9162I" },
		{ "Q5AB", "CW9162I" },
		{ "Q5AC", "CW9164I" },
		{ "Q5AE", "CW9166I" },
		{ "Q5AG", "CW9166D1" },
		{ "Q5AJ", "CW9163E" },
		{ "Q5AL", "CW9164I" },
		{ "Q5AM", "CW9166I" },
		{ "Q5AN", "CW9164I" },
		{ "Q5BA", "CW9178I" },
		{ "Q5BB", "CW9176I" },
		{ "Q5BC", "CW9176D1" },
		{ "Q5BE", "CW9172I" },
		{ "Q5JD", "C9300X-24Y" },
		{ "Q5JG", "C9300L-24P-4X" },
		{ "Q5JQ", "C9300X-48TX" },
		{ "Q5KA", "C9300-24P" },
		{ "Q5KB", "C9300-24T" },
		{ "Q5KE", "C9300-48P" },
		{ "Q5TA", "C9300-24P" },
		{ "Q5TC", "C9300-24U" },
		{ "Q5TF", "C9300-48T" },
		{ "Q5TM", "C9300X-12Y" },
		{ "Q5TP", "C9300L-24UXG-4X" },
		{ "Q5TX", "C9300X-24HX" },
		{ "Q5TV", "C9300L-48T-4X" },
		{ "Q5UA", "C9200L-24T-4X" },
		{ "Q5UL", "C9200L-24P-4G" },
	};

	/// <summary>
	/// This information from a ReportMagic call: [Meraki.EndOfLife: =>Array]
	/// </summary>
	private static readonly List<JObject> _eoxData = JsonConvert.DeserializeObject<List<JObject>>("""
 [
   {
     "DeviceModel": "GS110-8P",
     "Region": "UK",
     "Announcement": "2023-02-24 00:00:00",
     "EndOfSale": "2023-08-24 00:00:00",
     "EndOfSupport": "2025-08-24 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/21378/GS110-8P-HW-UK_EOS_Notice.pdf?revision=1"
   },
   {
     "DeviceModel": "GS110-8P",
     "Region": "EU",
     "Announcement": "2023-02-24 00:00:00",
     "EndOfSale": "2023-08-24 00:00:00",
     "EndOfSupport": "2025-08-24 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/21379/GS110-8P-HW-EU_EOS_Notice.pdf?revision=1"
   },
   {
     "DeviceModel": "GS110-8P",
     "Region": "US",
     "Announcement": "2023-02-24 00:00:00",
     "EndOfSale": "2023-06-01 00:00:00",
     "EndOfSupport": "2025-08-24 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/22304/GS110-8P-HW-US_EOS_Notice_Updated.pdf?revision=1"
   },
   {
     "DeviceModel": "GS110-24P",
     "Region": "UK",
     "Announcement": "2023-02-24 00:00:00",
     "EndOfSale": "2023-06-28 00:00:00",
     "EndOfSupport": "2025-08-24 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/21381/GS110-24P-HW-UK_EOS_Notice.pdf?revision=2"
   },
   {
     "DeviceModel": "GS110-24P",
     "Region": "EU",
     "Announcement": "2023-02-24 00:00:00",
     "EndOfSale": "2023-06-28 00:00:00",
     "EndOfSupport": "2025-08-24 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/21382/GS110-24P-HW-EU_EOS_Notice.pdf?revision=2"
   },
   {
     "DeviceModel": "GS110-24P",
     "Region": "US",
     "Announcement": "2023-02-24 00:00:00",
     "EndOfSale": "2023-06-01 00:00:00",
     "EndOfSupport": "2025-08-24 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/22305/GS110-24P-HW-US_EOS_Notice_Updated.pdf?revision=1"
   },
   {
     "DeviceModel": "GS110-48P",
     "Region": "UK",
     "Announcement": "2023-02-24 00:00:00",
     "EndOfSale": "2023-03-09 00:00:00",
     "EndOfSupport": "2025-08-24 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/21360/GS110-48P-HW-UK_EOS_Notice.pdf?revision=1"
   },
   {
     "DeviceModel": "GS110-48P",
     "Region": "EU",
     "Announcement": "2023-02-24 00:00:00",
     "EndOfSale": "2023-08-24 00:00:00",
     "EndOfSupport": "2025-08-24 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/21362/GS110-48P-HW-EU_EOS_Notice.pdf?revision=1"
   },
   {
     "DeviceModel": "GS110-48P",
     "Region": "US",
     "Announcement": "2023-02-24 00:00:00",
     "EndOfSale": "2023-06-01 00:00:00",
     "EndOfSupport": "2025-08-24 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/22308/GS110-48P-HW-US_EOS_Notice_Updated.pdf?revision=1"
   },
   {
     "DeviceModel": "GS110-8",
     "Region": "UK",
     "Announcement": "2023-02-24 00:00:00",
     "EndOfSale": "2023-08-24 00:00:00",
     "EndOfSupport": "2025-08-24 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/21375/GS110-8-HW-UK_EOS_Notice.pdf?revision=1"
   },
   {
     "DeviceModel": "GS110-8",
     "Region": "EU",
     "Announcement": "2023-02-24 00:00:00",
     "EndOfSale": "2023-08-24 00:00:00",
     "EndOfSupport": "2025-08-24 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/21376/GS110-8-HW-EU_EOS_Notice.pdf?revision=1"
   },
   {
     "DeviceModel": "GS110-8",
     "Region": "US",
     "Announcement": "2023-02-24 00:00:00",
     "EndOfSale": "2023-08-24 00:00:00",
     "EndOfSupport": "2025-08-24 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/21374/GS110-8-HW-US_EOS_Notice.pdf?revision=1"
   },
   {
     "DeviceModel": "GS110-48",
     "Region": "UK",
     "Announcement": "2023-02-24 00:00:00",
     "EndOfSale": "2023-08-24 00:00:00",
     "EndOfSupport": "2025-08-24 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/21371/GS110-48-HW-UK_EOS_Notice.pdf?revision=1"
   },
   {
     "DeviceModel": "GS110-48",
     "Region": "EU",
     "Announcement": "2023-02-24 00:00:00",
     "EndOfSale": "2023-08-24 00:00:00",
     "EndOfSupport": "2025-08-24 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/21373/GS110-48-HW-EU_EOS_Notice.pdf?revision=1"
   },
   {
     "DeviceModel": "GS110-48",
     "Region": "US",
     "Announcement": "2023-02-24 00:00:00",
     "EndOfSale": "2023-06-01 00:00:00",
     "EndOfSupport": "2025-08-24 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/22309/GS110-48-HW-US_EOS_Notice_Updated.pdf?revision=1"
   },
   {
     "DeviceModel": "GS110-24",
     "Region": "UK",
     "Announcement": "2023-02-24 00:00:00",
     "EndOfSale": "2023-08-24 00:00:00",
     "EndOfSupport": "2025-08-24 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/21367/GS110-24-HW-UK_EOS_Notice.pdf?revision=1"
   },
   {
     "DeviceModel": "GS110-24",
     "Region": "EU",
     "Announcement": "2023-02-24 00:00:00",
     "EndOfSale": "2023-08-24 00:00:00",
     "EndOfSupport": "2025-08-24 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/21368/GS110-24-HW-EU_EOS_Notice.pdf?revision=1"
   },
   {
     "DeviceModel": "GS110-24",
     "Region": "US",
     "Announcement": "2023-02-24 00:00:00",
     "EndOfSale": "2023-08-24 00:00:00",
     "EndOfSupport": "2025-08-24 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/21366/GS110-24-HW-US_EOS_Notice.pdf?revision=1"
   },
   {
     "DeviceModel": "MA-MNT-MR-H3",
     "Region": null,
     "Announcement": "2022-12-19 00:00:00",
     "EndOfSale": "2023-06-13 00:00:00",
     "EndOfSupport": "2028-06-13 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/20661/MA-MNT-MR-H3_EOS_Notice.pdf?revision=1"
   },
   {
     "DeviceModel": "MA-MNT-MR-H1",
     "Region": null,
     "Announcement": "2022-12-19 00:00:00",
     "EndOfSale": "2023-06-13 00:00:00",
     "EndOfSupport": "2028-06-13 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/20626/MA-MNT-MR-H1_EOS_Notice_.pdf?revision=2"
   },
   {
     "DeviceModel": "MR20",
     "Region": null,
     "Announcement": "2022-12-19 00:00:00",
     "EndOfSale": "2023-06-01 00:00:00",
     "EndOfSupport": "2028-06-13 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/22295/MR20_EOS_Notice_Updated.pdf?revision=1"
   },
   {
     "DeviceModel": "GR10",
     "Region": "UK",
     "Announcement": "2022-10-21 00:00:00",
     "EndOfSale": "2023-04-24 00:00:00",
     "EndOfSupport": "2025-04-24 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/20061/GR10-HW-UK_EOS_Notice.pdf?revision=1"
   },
   {
     "DeviceModel": "GR10",
     "Region": "EU",
     "Announcement": "2022-10-21 00:00:00",
     "EndOfSale": "2023-04-24 00:00:00",
     "EndOfSupport": "2025-04-24 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/20060/GR10-HW-EU_EOS_Notice.pdf?revision=1"
   },
   {
     "DeviceModel": "GR10",
     "Region": "US",
     "Announcement": "2022-10-21 00:00:00",
     "EndOfSale": "2023-04-24 00:00:00",
     "EndOfSupport": "2025-04-24 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/20059/GR10-HW-US_EOS_Notice.pdf?revision=1"
   },
   {
     "DeviceModel": "GR60",
     "Region": "UK",
     "Announcement": "2022-10-21 00:00:00",
     "EndOfSale": "2023-04-24 00:00:00",
     "EndOfSupport": "2025-04-24 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/20058/GR60-HW-UK_EOS_Notice.pdf?revision=1"
   },
   {
     "DeviceModel": "GR60",
     "Region": "EU",
     "Announcement": "2022-10-21 00:00:00",
     "EndOfSale": "2023-04-24 00:00:00",
     "EndOfSupport": "2025-04-24 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/20057/GR60-HW-EU_EOS_Notice.pdf?revision=1"
   },
   {
     "DeviceModel": "GR60",
     "Region": "US",
     "Announcement": "2022-10-21 00:00:00",
     "EndOfSale": "2023-04-24 00:00:00",
     "EndOfSupport": "2025-04-24 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/21883/GR60-HW-US_EOS_Notice_v1.pdf?revision=1"
   },
   {
     "DeviceModel": "MR42",
     "Region": null,
     "Announcement": "2021-01-27 00:00:00",
     "EndOfSale": "2022-07-14 00:00:00",
     "EndOfSupport": "2026-07-21 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/18680/MR42_EOS_Notice_updated_June_2022.pdf?revision=1"
   },
   {
     "DeviceModel": "MR33",
     "Region": null,
     "Announcement": "2021-01-27 00:00:00",
     "EndOfSale": "2022-07-14 00:00:00",
     "EndOfSupport": "2026-07-21 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/18677/MR33_EOS_Notice_June_2022.pdf?revision=1"
   },
   {
     "DeviceModel": "MR30H",
     "Region": null,
     "Announcement": null,
     "EndOfSale": "2022-05-31 00:00:00",
     "EndOfSupport": "2027-07-26 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/18025/MR30H_EOS_Notice-Updated_May_2022.pdf?revision=3"
   },
   {
     "DeviceModel": "MR42E",
     "Region": null,
     "Announcement": "2022-04-22 00:00:00",
     "EndOfSale": "2022-04-22 00:00:00",
     "EndOfSupport": "2026-07-21 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/17742/MR42E_EOS_Notice_updated_May_2022.pdf?revision=1"
   },
   {
     "DeviceModel": "MR55",
     "Region": null,
     "Announcement": "2022-02-15 00:00:00",
     "EndOfSale": "2022-04-07 00:00:00",
     "EndOfSupport": "2028-08-01 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/17560/MR55_EOS_Notice_updated_April_2022.pdf?revision=1"
   },
   {
     "DeviceModel": "MR53E",
     "Region": null,
     "Announcement": "2022-02-15 00:00:00",
     "EndOfSale": "2022-04-07 00:00:00",
     "EndOfSupport": "2026-07-21 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/17561/MR53E_EOS_Notice_updated_April_2022.pdf?revision=1"
   },
   {
     "DeviceModel": "MR52",
     "Region": null,
     "Announcement": "2022-02-15 00:00:00",
     "EndOfSale": "2022-04-07 00:00:00",
     "EndOfSupport": "2026-07-21 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/17558/MR52_EOS_Notice_updated_April_2022.pdf?revision=1"
   },
   {
     "DeviceModel": "MX64,",
     "Region": "MX64W",
     "Announcement": "2022-01-26 00:00:00",
     "EndOfSale": "2022-07-26 00:00:00",
     "EndOfSupport": "2027-07-26 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/16988/MX64_EOS_Notice.pdf?revision=1"
   },
   {
     "DeviceModel": "MA-INJ-4-XX (AU,",
     "Region": "CN,",
     "Announcement": "2021-10-29 00:00:00",
     "EndOfSale": "2021-11-30 00:00:00",
     "EndOfSupport": "2022-11-30 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/16218/MA-INJ-4-XX_EOS_Notice_v3.pdf?revision=1"
   },
   {
     "DeviceModel": "MS390",
     "Region": "4x10GE",
     "Announcement": "2021-08-30 00:00:00",
     "EndOfSale": "2021-11-01 00:00:00",
     "EndOfSupport": null,
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/18529/MA-MOD-4X10G_EOS_Notice_Updated_June_2022.pdf?revision=2"
   },
   {
     "DeviceModel": "MX100",
     "Region": null,
     "Announcement": "2021-08-10 00:00:00",
     "EndOfSale": "2022-02-01 00:00:00",
     "EndOfSupport": "2027-02-01 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/20901/MX100_Successoor_PID_Update_to_MX95.pdf?revision=1"
   },
   {
     "DeviceModel": "MX84",
     "Region": null,
     "Announcement": "2021-08-10 00:00:00",
     "EndOfSale": "2021-10-31 00:00:00",
     "EndOfSupport": "2026-10-31 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/15599/MX84_EOS_Notice.pdf?revision=1"
   },
   {
     "DeviceModel": "MA-INJ-5",
     "Region": null,
     "Announcement": "2021-06-01 00:00:00",
     "EndOfSale": "2021-06-29 00:00:00",
     "EndOfSupport": null,
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/15527/INJ_5_2021_EOS_Notice_Jun30-2021.pdf?revision=1"
   },
   {
     "DeviceModel": "MR84",
     "Region": null,
     "Announcement": "2021-05-03 00:00:00",
     "EndOfSale": "2021-05-07 00:00:00",
     "EndOfSupport": "2026-07-21 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/15395/MR_Multi_EOS_Notice_May_7_2021.pdf?revision=1"
   },
   {
     "DeviceModel": "MR74",
     "Region": null,
     "Announcement": "2021-01-27 00:00:00",
     "EndOfSale": "2021-07-21 00:00:00",
     "EndOfSupport": "2026-07-21 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/15395/MR_Multi_EOS_Notice_May_7_2021.pdf?revision=1"
   },
   {
     "DeviceModel": "MR53",
     "Region": null,
     "Announcement": "2021-05-03 00:00:00",
     "EndOfSale": "2021-05-07 00:00:00",
     "EndOfSupport": "2026-07-21 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/15395/MR_Multi_EOS_Notice_May_7_2021.pdf?revision=1"
   },
   {
     "DeviceModel": "MR45",
     "Region": null,
     "Announcement": "2021-01-27 00:00:00",
     "EndOfSale": "2021-07-21 00:00:00",
     "EndOfSupport": "2026-07-21 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/15395/MR_Multi_EOS_Notice_May_7_2021.pdf?revision=1"
   },
   {
     "DeviceModel": "vMX100",
     "Region": null,
     "Announcement": "2020-09-29 00:00:00",
     "EndOfSale": "2020-12-22 00:00:00",
     "EndOfSupport": "2027-12-22 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/17557/meraki_eol_vmx100.pdf?revision=1"
   },
   {
     "DeviceModel": "MV21 &",
     "Region": "MV71",
     "Announcement": "2019-03-19 00:00:00",
     "EndOfSale": "2019-06-19 00:00:00",
     "EndOfSupport": "2026-06-19 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/17023/MV21_MV71_EOS_Notice_Update.pdf?revision=1"
   },
   {
     "DeviceModel": "MX65",
     "Region": null,
     "Announcement": "2018-11-20 00:00:00",
     "EndOfSale": "2019-05-28 00:00:00",
     "EndOfSupport": "2026-05-28 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/20480/meraki_eol_mx65_update.pdf?revision=1"
   },
   {
     "DeviceModel": "MC74",
     "Region": null,
     "Announcement": "2018-09-27 00:00:00",
     "EndOfSale": "2018-10-01 00:00:00",
     "EndOfSupport": "2019-04-01 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/17021/meraki_eol_mc74.pdf?revision=1"
   },
   {
     "DeviceModel": "Z1",
     "Region": null,
     "Announcement": "2018-04-27 00:00:00",
     "EndOfSale": "2018-07-27 00:00:00",
     "EndOfSupport": "2025-07-27 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/17025/meraki-eol-Z1.pdf?revision=1"
   },
   {
     "DeviceModel": "MX600",
     "Region": null,
     "Announcement": "2018-02-28 00:00:00",
     "EndOfSale": "2018-05-20 00:00:00",
     "EndOfSupport": "2025-05-20 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/17020/meraki_eol_mx400_mx600.pdf?revision=1"
   },
   {
     "DeviceModel": "MX400",
     "Region": null,
     "Announcement": "2018-02-28 00:00:00",
     "EndOfSale": "2018-05-20 00:00:00",
     "EndOfSupport": "2025-05-20 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/17020/meraki_eol_mx400_mx600.pdf?revision=1"
   },
   {
     "DeviceModel": "MS220-8",
     "Region": null,
     "Announcement": "2018-01-09 00:00:00",
     "EndOfSale": "2018-07-28 00:00:00",
     "EndOfSupport": "2025-07-28 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/17035/meraki_eol_ms220-8.pdf?revision=1"
   },
   {
     "DeviceModel": "ANT-10",
     "Region": null,
     "Announcement": "2017-09-06 00:00:00",
     "EndOfSale": "2017-09-11 00:00:00",
     "EndOfSupport": "2024-09-11 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/17005/meraki_eol_ant10.pdf?revision=1"
   },
   {
     "DeviceModel": "MR62",
     "Region": null,
     "Announcement": "2017-08-15 00:00:00",
     "EndOfSale": "2017-11-15 00:00:00",
     "EndOfSupport": "2024-11-15 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/16998/meraki_eol_mr62.pdf?revision=1"
   },
   {
     "DeviceModel": "MR66",
     "Region": null,
     "Announcement": "2017-06-07 00:00:00",
     "EndOfSale": "2017-06-09 00:00:00",
     "EndOfSupport": "2024-06-09 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/16999/meraki_eol_mr66.pdf?revision=1"
   },
   {
     "DeviceModel": "MS220 series",
     "Region": null,
     "Announcement": "2017-03-16 00:00:00",
     "EndOfSale": "2017-07-29 00:00:00",
     "EndOfSupport": "2024-07-29 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/17036/meraki_eol_ms220.pdf?revision=1"
   },
   {
     "DeviceModel": "MR72",
     "Region": null,
     "Announcement": "2017-03-07 00:00:00",
     "EndOfSale": "2017-04-30 00:00:00",
     "EndOfSupport": "2024-04-30 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/17000/meraki_eol_mr72.pdf?revision=1"
   },
   {
     "DeviceModel": "MR32",
     "Region": null,
     "Announcement": "2017-01-18 00:00:00",
     "EndOfSale": "2017-04-30 00:00:00",
     "EndOfSupport": "2024-07-31 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/17009/meraki_eol_mr32.pdf?revision=1"
   },
   {
     "DeviceModel": "MS320 series",
     "Region": null,
     "Announcement": "2016-12-08 00:00:00",
     "EndOfSale": "2017-03-31 00:00:00",
     "EndOfSupport": "2024-03-31 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/17011/meraki_eol_ms320.pdf?revision=1"
   },
   {
     "DeviceModel": "MR18",
     "Region": null,
     "Announcement": "2016-12-08 00:00:00",
     "EndOfSale": "2017-02-13 00:00:00",
     "EndOfSupport": "2024-03-31 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/17008/meraki_eol_mr18.pdf?revision=1"
   },
   {
     "DeviceModel": "MS420",
     "Region": null,
     "Announcement": "2016-08-01 00:00:00",
     "EndOfSale": "2016-10-31 00:00:00",
     "EndOfSupport": "2023-10-31 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/17012/meraki_eol_ms420.pdf?revision=1"
   },
   {
     "DeviceModel": "MR34",
     "Region": null,
     "Announcement": "2016-08-01 00:00:00",
     "EndOfSale": "2016-10-31 00:00:00",
     "EndOfSupport": "2023-10-31 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/17010/meraki_eol_mr34.pdf?revision=1"
   },
   {
     "DeviceModel": "AC-MR-1-XX (AU, EU,",
     "Region": "UK,",
     "Announcement": "2016-02-09 00:00:00",
     "EndOfSale": "2016-05-09 00:00:00",
     "EndOfSupport": "2023-05-09 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/16990/meraki_eol_ac_mr_1_xx.pdf?revision=1"
   },
   {
     "DeviceModel": "MR26",
     "Region": null,
     "Announcement": "2016-02-09 00:00:00",
     "EndOfSale": "2016-05-09 00:00:00",
     "EndOfSupport": "2023-05-09 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/17030/meraki_eol_mr26.pdf?revision=1"
   },
   {
     "DeviceModel": "MX80",
     "Region": null,
     "Announcement": "2016-01-26 00:00:00",
     "EndOfSale": "2016-08-30 00:00:00",
     "EndOfSupport": "2023-08-30 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/17015/meraki_eol_mx80.pdf?revision=1"
   },
   {
     "DeviceModel": "MS320",
     "Region": "&",
     "Announcement": "2015-11-16 00:00:00",
     "EndOfSale": "2015-11-16 00:00:00",
     "EndOfSupport": "2022-11-16 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/17002/meraki_eol_psu_fan.pdf?revision=1"
   },
   {
     "DeviceModel": "MR12",
     "Region": null,
     "Announcement": "2015-07-27 00:00:00",
     "EndOfSale": "2015-10-24 00:00:00",
     "EndOfSupport": "2022-10-24 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/17027/meraki_eol_mr12.pdf?revision=1"
   },
   {
     "DeviceModel": "MX60W",
     "Region": null,
     "Announcement": "2015-07-10 00:00:00",
     "EndOfSale": "2015-10-24 00:00:00",
     "EndOfSupport": "2022-10-24 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/17014/meraki_eol_mx60w.pdf?revision=1"
   },
   {
     "DeviceModel": "MX60",
     "Region": null,
     "Announcement": "2015-07-10 00:00:00",
     "EndOfSale": "2015-10-24 00:00:00",
     "EndOfSupport": "2022-10-24 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/17013/meraki_eol_mx60.pdf?revision=1"
   },
   {
     "DeviceModel": "ANT-13",
     "Region": null,
     "Announcement": "2015-01-12 00:00:00",
     "EndOfSale": "2015-04-24 00:00:00",
     "EndOfSupport": "2022-04-24 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/16997/meraki_eol_ant13.pdf?revision=1"
   },
   {
     "DeviceModel": "ANT-11",
     "Region": null,
     "Announcement": "2015-01-12 00:00:00",
     "EndOfSale": "2015-04-24 00:00:00",
     "EndOfSupport": "2022-04-24 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/16996/meraki_eol_ant11.pdf?revision=1"
   },
   {
     "DeviceModel": "Systems",
     "Region": "Manager",
     "Announcement": "2014-09-22 00:00:00",
     "EndOfSale": "2014-09-22 00:00:00",
     "EndOfSupport": null,
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/17003/meraki_eol_systems_manager_support_license.pdf?revision=1"
   },
   {
     "DeviceModel": "802.3af",
     "Region": "PoE",
     "Announcement": "2014-02-27 00:00:00",
     "EndOfSale": "2014-05-31 00:00:00",
     "EndOfSupport": "2021-05-31 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/16991/meraki_eol_802.3af_poe.pdf?revision=1"
   },
   {
     "DeviceModel": "MR24",
     "Region": null,
     "Announcement": "2014-02-27 00:00:00",
     "EndOfSale": "2014-05-31 00:00:00",
     "EndOfSupport": "2021-05-31 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/17029/meraki_eol_mr24.pdf?revision=1"
   },
   {
     "DeviceModel": "MR16",
     "Region": null,
     "Announcement": "2014-02-27 00:00:00",
     "EndOfSale": "2014-05-31 00:00:00",
     "EndOfSupport": "2021-05-31 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/17019/meraki_eol_mr16.pdf?revision=1"
   },
   {
     "DeviceModel": "MS22/P",
     "Region": "and",
     "Announcement": "2014-01-06 00:00:00",
     "EndOfSale": "2014-01-25 00:00:00",
     "EndOfSupport": null,
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/17017/meraki-eos-ms22-ms42-licenses.pdf?revision=1"
   },
   {
     "DeviceModel": "SFP/SFP+",
     "Region": "Accessories",
     "Announcement": "2013-11-05 00:00:00",
     "EndOfSale": "2014-04-26 00:00:00",
     "EndOfSupport": "2021-04-26 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/17018/meraki_eol_ms_accessories.pdf?revision=1"
   },
   {
     "DeviceModel": "MS42P",
     "Region": null,
     "Announcement": "2013-11-05 00:00:00",
     "EndOfSale": "2014-04-26 00:00:00",
     "EndOfSupport": "2021-04-26 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/17034/meraki_eol_ms42p.pdf?revision=1"
   },
   {
     "DeviceModel": "MS42",
     "Region": null,
     "Announcement": "2013-11-05 00:00:00",
     "EndOfSale": "2014-04-26 00:00:00",
     "EndOfSupport": "2021-04-26 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/17033/meraki_eol_ms42.pdf?revision=1"
   },
   {
     "DeviceModel": "MS22P",
     "Region": null,
     "Announcement": "2013-11-05 00:00:00",
     "EndOfSale": "2014-04-26 00:00:00",
     "EndOfSupport": "2021-04-26 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/17032/meraki_eol_ms22p.pdf?revision=1"
   },
   {
     "DeviceModel": "MS22",
     "Region": null,
     "Announcement": "2013-11-05 00:00:00",
     "EndOfSale": "2014-04-26 00:00:00",
     "EndOfSupport": "2021-04-26 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/17031/meraki_eol_ms22.pdf?revision=1"
   },
   {
     "DeviceModel": "MX90",
     "Region": null,
     "Announcement": "2013-11-05 00:00:00",
     "EndOfSale": "2014-04-26 00:00:00",
     "EndOfSupport": "2021-04-26 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/17016/meraki_eol_mx90.pdf?revision=1"
   },
   {
     "DeviceModel": "MR58",
     "Region": null,
     "Announcement": "2012-07-26 00:00:00",
     "EndOfSale": "2012-10-30 00:00:00",
     "EndOfSupport": "2017-10-30 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/16993/meraki_eol_mr58.pdf?revision=1"
   },
   {
     "DeviceModel": "OD2",
     "Region": null,
     "Announcement": "2012-07-26 00:00:00",
     "EndOfSale": "2012-10-30 00:00:00",
     "EndOfSupport": "2017-10-30 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/16995/meraki_eol_od2.pdf?revision=1"
   },
   {
     "DeviceModel": "MR14",
     "Region": null,
     "Announcement": "2012-05-29 00:00:00",
     "EndOfSale": "2012-08-30 00:00:00",
     "EndOfSupport": "2017-08-30 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/17028/meraki_eol_mr14.pdf?revision=1"
   },
   {
     "DeviceModel": "MR11",
     "Region": null,
     "Announcement": "2012-05-29 00:00:00",
     "EndOfSale": "2012-08-30 00:00:00",
     "EndOfSupport": "2017-08-30 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/17006/meraki_eol_mr11.pdf?revision=1"
   },
   {
     "DeviceModel": "MX70",
     "Region": null,
     "Announcement": "2012-01-18 00:00:00",
     "EndOfSale": "2012-03-31 00:00:00",
     "EndOfSupport": "2017-03-31 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/16994/meraki_eol_mx70.pdf?revision=1"
   },
   {
     "DeviceModel": "MX50",
     "Region": null,
     "Announcement": "2011-07-15 00:00:00",
     "EndOfSale": "2011-09-01 00:00:00",
     "EndOfSupport": "2016-09-01 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/17001/meraki_eol_mx50.pdf?revision=1"
   },
   {
     "DeviceModel": "Indoor",
     "Region": null,
     "Announcement": "2011-03-03 00:00:00",
     "EndOfSale": "2011-06-30 00:00:00",
     "EndOfSupport": "2016-06-30 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/16992/meraki_eol_indoor.pdf?revision=1"
   },
   {
     "DeviceModel": "Mini",
     "Region": null,
     "Announcement": "2010-09-03 00:00:00",
     "EndOfSale": "2010-12-31 00:00:00",
     "EndOfSupport": "2017-09-25 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/17007/meraki_eol_mini.pdf?revision=1"
   },
   {
     "DeviceModel": "Wall",
     "Region": "Plug",
     "Announcement": "2010-09-03 00:00:00",
     "EndOfSale": "2010-12-31 00:00:00",
     "EndOfSupport": "2015-12-31 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/17004/meraki_eol_wallplug_solar.pdf?revision=1"
   },
   {
     "DeviceModel": "Solar",
     "Region": null,
     "Announcement": "2010-09-03 00:00:00",
     "EndOfSale": "2010-12-31 00:00:00",
     "EndOfSupport": "2015-12-31 00:00:00",
     "EosNoticeUrl": "https://documentation.meraki.com/@api/deki/files/17004/meraki_eol_wallplug_solar.pdf?revision=1"
   }
 ]
 """) ?? throw new FormatException("Check source file for valid eox data.");

	/// <summary>
	/// Returns a list of end-of-life data
	/// Data regularly updated from https://documentation.meraki.com/General_Administration/Other_Topics/Meraki_End-of-Life_(EOL)_Products_and_Dates
	/// </summary>
	public static SerialNumberInfo GetInfoFromSerialNumber(string serialNumber)
	{
		if (string.IsNullOrWhiteSpace(serialNumber))
		{
			throw new ArgumentException("Value cannot be null or whitespace.", nameof(serialNumber));
		}

		// Serial number should be in the format XXXX-XXXX-XXXX
		if (serialNumber.Length != 14)
		{
			throw new ArgumentException("Serial number should be in the format XXXX-XXXX-XXXX", nameof(serialNumber));
		}

		var model = _serialNumberModels.TryGetValue(serialNumber.Substring(0, 4), out var m)
			? m
			: null;

		var productType =
			model is null ? null :
			model.StartsWith("MX", StringComparison.Ordinal) || model.StartsWith("Z", StringComparison.Ordinal) ? ProductType.Appliance :
			model.StartsWith("MS", StringComparison.Ordinal) ? ProductType.Switch :
			model.StartsWith("MR", StringComparison.Ordinal) || model.StartsWith("CW", StringComparison.Ordinal) ? ProductType.Wireless :
			model.StartsWith("MV", StringComparison.Ordinal) ? ProductType.Camera :
			model.StartsWith("MG", StringComparison.Ordinal) ? ProductType.CellularGateway :
			model.StartsWith("MC", StringComparison.Ordinal) ? ProductType.Phone :
			model.StartsWith("MT", StringComparison.Ordinal) ? ProductType.Sensor :
			(ProductType?)null;

		var eox = _eoxData.Find(eox => eox?["DeviceModel"]?.ToString() == model);
		var endOfSaleDateTime = eox?["EndOfSale"]?.ToObject<DateTime?>();
		var endOfSupportDateTime = eox?["EndOfSupport"]?.ToObject<DateTime?>();
		var endOfSaleNoticeUrl = eox?["EosNoticeUrl"]?.ToString();

		return new SerialNumberInfo
		{
			SerialNumber = serialNumber,
			ProductType = productType,
			IsVirtual = model?[0] == 'v',
			Model = model ?? "Unknown",
			EndOfSale = endOfSaleDateTime is null ? null : new DateTimeOffset(endOfSaleDateTime.Value, TimeSpan.Zero),
			EndOfSupport = endOfSupportDateTime is null ? null : new DateTimeOffset(endOfSupportDateTime.Value, TimeSpan.Zero),
			EndOfSaleNoticeUrl = endOfSaleNoticeUrl
		};
	}
}
