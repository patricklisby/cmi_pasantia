namespace CuadroMandoIntegral.Models
{
	public class Permiso
	{
		public int PermisoId { get; set; }

		public string NombrePermiso { get; set; }

		public virtual ICollection<PermisoRolSeccion> PermisoRolSeccion { get; set; }
		public virtual ICollection<PermisoEmpresaModulo> PermisoEmpresaModulo { get; set; }

	}
}
