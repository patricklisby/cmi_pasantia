using System.ComponentModel.DataAnnotations.Schema;

namespace CuadroMandoIntegral.Models
{
	public class Perspectivas
	{
		public int IdPerspectia { get; set; }

		public string NombrePerspectiva { get; set; }

		public string DescripcionPerspectiva { get; set; }

		public bool Estado { get; set; }

		public int EmpresaId { get; set; }

		[ForeignKey("EmpresaId")]
		public Empresa Empresa { get; set; }

	}
}
