using System.ComponentModel.DataAnnotations.Schema;

namespace CuadroMandoIntegral.Models
{
	public class PermisoEmpresaModulo
	{
		public int IdPermiso { get; set; }

		[ForeignKey("IdPermiso")]
		public Permiso Permiso { get; set; }

		public int IdEmpresa { get; set; }

		[ForeignKey("IdEmpresa")]
		public Empresa Empresa { get; set; }

		public int IdModulo { get; set; }

		[ForeignKey("IdModulo")]
		public Modulo Modulo { get; set; }
	}
}
