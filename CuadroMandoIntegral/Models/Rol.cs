namespace CuadroMandoIntegral.Models
{
	public class Rol
	{
		public int? rolId { get; set; }
		public string? descripcion { get; set; }

		public virtual ICollection<Persona> Persona { get; set; }

		public virtual ICollection<PermisoRolSeccion> PermisoRolSeccion { get; set; }
	}
}
