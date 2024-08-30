namespace CuadroMandoIntegral.Models
{
	public class Modulo
	{
		public int ModuloId { get; set; }

		public string NombreModulo { get; set; }

		public virtual ICollection<PermisoEmpresaModulo> PermisoEmpresaModulo { get; set; }
	}
}
