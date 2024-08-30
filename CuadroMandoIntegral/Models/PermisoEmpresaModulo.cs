using System.ComponentModel.DataAnnotations.Schema;

namespace CuadroMandoIntegral.Models
{
	public class PermisoEmpresaModulo
	{
		public int PermisoId { get; set; }

		[ForeignKey("PermisoId")]
		public Permiso Permiso { get; set; }

		public int EmpresaId { get; set; }

		[ForeignKey("EmpresaId")]
		public Empresa Empresa { get; set; }

		public int ModuloId { get; set; }

		[ForeignKey("ModuloId")]
		public Modulo Modulo { get; set; }
	}
}
