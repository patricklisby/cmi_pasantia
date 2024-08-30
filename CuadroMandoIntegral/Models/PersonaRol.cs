using System.ComponentModel.DataAnnotations.Schema;

namespace CuadroMandoIntegral.Models
{
	public class PersonaRol
	{
		
		public int IdRol { get; set; }
		
		public int PersonaId { get; set; }

		[ForeignKey("IdRol")]
		public Rol Rol { get; set; }

		[ForeignKey("PersonaId")]
		public Persona Persona { get; set; }
	}
}
