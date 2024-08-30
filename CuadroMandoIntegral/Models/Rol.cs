namespace CuadroMandoIntegral.Models
{
	public class Rol
	{
		public int? IdRol { get; set; }
		public string? descripcion { get; set; }

		public virtual ICollection<Persona> Persona { get; set; }

		public virtual ICollection<PermisoRolSeccion> PermisoRolSeccion { get; set; }
	}
}
