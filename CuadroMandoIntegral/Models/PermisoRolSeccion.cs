using System.ComponentModel.DataAnnotations.Schema;

namespace CuadroMandoIntegral.Models
{
	public class PermisoRolSeccion
	{
		public int PermisoId { get; set; }

		[ForeignKey("PermisoId")]
		public Permiso Permiso { get; set; }

		public int RolId { get; set; }

		[ForeignKey("RolId")]
		public Rol Rol { get; set; }

		public int SeccionId { get; set; }

		[ForeignKey("SeccionId")]
		public SeccionSistema SeccionSistema { get; set; }

	}
}
