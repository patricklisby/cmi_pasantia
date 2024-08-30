using System.ComponentModel.DataAnnotations.Schema;

namespace CuadroMandoIntegral.Models
{
	public class Objetivos
	{
		public int IdObjetivo { get; set; }
		public string NombreObjetivo { get; set; }

		public string DescripcionObjetivo { get; set; }

		public bool Estado {  get; set; }

		public int PerspectivaId {  get; set; }

		[ForeignKey("PerspectivaId")]
		public Perspectivas Perspectivas { get; set; }

	}
}
