namespace CuadroMandoIntegral.Models
{
	public class SeccionSistema
	{
		public int SeccionId { get; set; }

		public string NombreSeccion { get; set; }

		public virtual ICollection<PermisoRolSeccion> PermisoRolSeccion { get; set; }
	}
}
