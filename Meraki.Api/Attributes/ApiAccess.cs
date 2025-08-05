namespace Meraki.Api.Attributes;

/// <summary>
/// Specifies the level of API access permissions.
/// </summary>
[Flags]
public enum ApiAccess
{
	/// <summary>
	/// No access is granted.
	/// </summary>
	NoAccess = 0,

	/// <summary>
	/// Read access is granted.
	/// </summary>
	Read = 1,

	/// <summary>
	/// Create access is granted.
	/// </summary>
	Create = 2,

	/// <summary>
	/// Read and Create access are granted.
	/// </summary>
	ReadCreate = Read | Create,

	/// <summary>
	/// Update access is granted.
	/// </summary>
	Update = 4,

	/// <summary>
	/// Read and Update access are granted.
	/// </summary>
	ReadUpdate = Read | Update,

	/// <summary>
	/// Create and Update access are granted.
	/// </summary>
	CreateUpdate = Create | Update,

	/// <summary>
	/// Read, Create, and Update access are granted.
	/// </summary>
	ReadWrite = Read | Create | Update
}
