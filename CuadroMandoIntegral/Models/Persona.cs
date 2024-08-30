using System.ComponentModel.DataAnnotations.Schema;

namespace CuadroMandoIntegral.Models
{
	public class Persona
	{
		public int IdPersona { get; set; }

		public string? Nombre { get; set; }

		public string? Apellido { get; set; }

		public string? Usuario { get; set; }

		public string? Contraseña { get; set; }

		public List<string>? roles { get; set; }

		public string? CambioContraseña { get; set; }

		public string? ConfirmarContraseña { get; set; }

		public string? Correo { get; set; }

		public DateTime? FechaCreacion { get; set; }

		public DateTime? FechaActual { get; set; }

		public string? TipoVigencia { get; set; }

		public int? vigencia { get; set; }

		[NotMapped]
		public bool activo { get; set; }

		public int DepartamentoId { get; set; }

		[ForeignKey("DepartamentoId")]
		public Departamento Departamento { get; set; }

		public virtual ICollection<Rol> Roles { get; set; }

	}
}
