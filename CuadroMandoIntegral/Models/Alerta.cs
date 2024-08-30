namespace CuadroMandoIntegral.Models
{
	public class Alerta
	{
		public int IdAlerta { get; set; }

		public string Nombre { get; set; }

		public string Condicional { get; set; }

		public int Valor { get; set; }

		public int idIndicador { get; set; }

		public Indicadores Indicador { get; set; }
	}
}
