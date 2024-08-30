using System.ComponentModel.DataAnnotations.Schema;

namespace CuadroMandoIntegral.Models
{
	public class UsuarioEmpresa
	{
		public int IdUsuario { get; set; }

		public int IdPersona { get; set; }

		[ForeignKey("IdPersona")]
		public Persona Persona { get; set; }

		public int IdEmpresa { get; set; }

		[ForeignKey("IdEmpresa")]
		public Empresa Empresa { get; set; }
	}
}
