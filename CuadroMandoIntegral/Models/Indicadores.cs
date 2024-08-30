namespace CuadroMandoIntegral.Models
{
	public class Indicadores
	{
		public int IdIndicador { get; set; }

		public string NombreIndicdor { get; set; }

		public string DescripcionIndicador { get; set; }

		public int ValorActual { get; set; }
		public int ValorReferencia {  get; set; }
		
		public int ValorIndicador { get; set; }

		public bool Estado { get; set; }
	}
}
