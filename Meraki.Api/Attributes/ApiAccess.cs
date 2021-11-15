namespace Meraki.Api.Attributes;

[Flags]
public enum ApiAccess
{
	NoAccess = 0,
	Read = 1,
	Create = 2,
	ReadCreate = Read | Create,
	Update = 4,
	ReadUpdate = Read | Update,
	CreateUpdate = Create | Update,
	ReadWrite = Read | Create | Update
}
