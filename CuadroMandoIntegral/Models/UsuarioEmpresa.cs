using System.ComponentModel.DataAnnotations.Schema;

namespace CuadroMandoIntegral.Models
{
	public class UsuarioEmpresa
	{
		public int IdUsuario { get; set; }

		public int PersonaID { get; set; }

		[ForeignKey("PersonaID")]
		public Persona Persona { get; set; }

		public int EmpresaId { get; set; }

		[ForeignKey("EmpresaId")]
		public Empresa Empresa { get; set; }
	}
}
