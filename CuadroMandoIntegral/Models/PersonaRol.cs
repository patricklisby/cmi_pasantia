using System.ComponentModel.DataAnnotations.Schema;

namespace CuadroMandoIntegral.Models
{
	public class PersonaRol
	{
		
		public int IdRol { get; set; }
		
		public int IdPersona { get; set; }

		[ForeignKey("IdRol")]
		public Rol Rol { get; set; }

		[ForeignKey("IdPersona")]
		public Persona Persona { get; set; }
	}
}
