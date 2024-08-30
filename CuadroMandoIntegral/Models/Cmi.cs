using System.ComponentModel.DataAnnotations.Schema;

namespace CuadroMandoIntegral.Models
{
	/*
		Hace falta añadir la relación con el usuario
	 */
	public class Cmi
	{
		public int IdCmi { get; set; }
		
		public string CmiName { get; set; }
		
		public DateTime FechaCaducidad { get; set; }

		public int EmpresaId { get; set; }

		[ForeignKey("EmpresaId")]
		public Empresa Empresa { get; set; }
	}
}
