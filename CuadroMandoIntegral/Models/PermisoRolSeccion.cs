using System.ComponentModel.DataAnnotations.Schema;

namespace CuadroMandoIntegral.Models
{
	public class PermisoRolSeccion
	{
		public int IdPermiso { get; set; }

		[ForeignKey("IdPermiso")]
		public Permiso Permiso { get; set; }

		public int IdRol { get; set; }

		[ForeignKey("IdRol")]
		public Rol Rol { get; set; }

		public int IdSeccion { get; set; }

		[ForeignKey("IdSeccion")]
		public SeccionSistema SeccionSistema { get; set; }

	}
}
